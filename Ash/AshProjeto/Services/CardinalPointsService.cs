using AshProjeto.Interfaces;
using AshProjeto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace AshProjeto.Services
{
    public sealed class CardinalPointsService : ICardinalPointsService
    {
        private readonly Dictionary<string, Point> _points;
        public const int COUNT_ERROR = -1;

        public CardinalPointsService(ICardinalPoints cardinalPoints)
        {
            if (cardinalPoints.IsEmpty())
            {
                throw new ArgumentNullException("cardinalPoints");
            }

            _points = cardinalPoints.ToDictionary();
        }

        public bool ValidMovement(char cardinal)
        {
            return _points.ContainsKey(cardinal.ToString());
        }
        public bool ValidMovement(Point point)
        {
            return _points.ContainsValue(point);
        }

        public Point ToPoint(char cardinal)
        {
            Point point = _points[cardinal.ToString()];
            if (point.IsEmpty())
            {
                point = CardinalPoints.ZERO;
            }
            return point;
        }

        public Point MoveTo(Point fromPoint, char toCardinal)
        {
            Point point = ToPoint(toCardinal);
            point.Offset(fromPoint.X, fromPoint.Y);
            return point;
        }

        public Point MoveTo(Point fromPoint, Point toPoint)
        {
            if (fromPoint.IsEmpty())
            {
                fromPoint = CardinalPoints.ZERO;
            }
            if (toPoint.IsEmpty())
            {
                toPoint = CardinalPoints.ZERO;
            }

            toPoint.Offset(fromPoint.X, fromPoint.Y);
            return toPoint;
        }

        public int GetTotalPokemons(IList<Point> points)
        {
            if (points.IsEmpty()) return COUNT_ERROR;

            HashSet<string> pokemonsCollected = new HashSet<string>();

            Point currentPoint = CardinalPoints.ZERO;

            string initialPoint = currentPoint.ToString();
            pokemonsCollected.Add(initialPoint);

            foreach (Point cardinalPoint in points)
            {
                if (!ValidMovement(cardinalPoint))
                {
                    return COUNT_ERROR;
                }

                currentPoint = MoveTo(currentPoint, cardinalPoint);

                if (!pokemonsCollected.Contains(currentPoint.ToString()))
                {
                    pokemonsCollected.Add(currentPoint.ToString());
                }
            }

            return pokemonsCollected.Count;
        }

        public IList<Point> ToPoints(string cardinalPoints)
        {
            if (cardinalPoints.IsEmpty())
            {
                return new List<Point>();
            }

            return cardinalPoints
                .ToCharArray()
                .AsEnumerable()
                .Select(s => ToPoint(s))
                .ToList();
        }
    }
}
