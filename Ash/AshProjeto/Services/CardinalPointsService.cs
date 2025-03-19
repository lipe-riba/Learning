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
            Point p = ToPoint(toCardinal);
            p.Offset(fromPoint.X, fromPoint.Y);
            return p;
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
            if (points.IsEmpty()) return -1;

            HashSet<string> hsPointsOfPokemonsCollected = new HashSet<string>();

            Point currentPoint = CardinalPoints.ZERO;

            string strInitialPoint = currentPoint.ToString();
            hsPointsOfPokemonsCollected.Add(strInitialPoint);

            foreach (Point cardinalPoint in points)
            {
                if (!ValidMovement(cardinalPoint))
                {
                    return -1;
                }

                currentPoint = MoveTo(currentPoint, cardinalPoint);
                strInitialPoint = currentPoint.ToString();

                if (!hsPointsOfPokemonsCollected.Contains(strInitialPoint))
                {
                    hsPointsOfPokemonsCollected.Add(strInitialPoint);
                }
            }

            return hsPointsOfPokemonsCollected.Count;
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
