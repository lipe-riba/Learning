using AshProjeto.Interfaces;
using AshProjeto.Models;
using System.Collections.Generic;
using System.Windows;

namespace AshProjeto.Services
{
    public sealed class CardinalPointsService : ICardinalPointsService
    {
        private Dictionary<string, Point> _points;

        public CardinalPointsService(ICardinalPoints cardinalPoints)
        {
            _points = cardinalPoints.ToDictionary();
        }

        public bool Valid(char cardinal)
        {
            return _points.ContainsKey(cardinal.ToString());
        }

        public Point ToPoint(char cardinal)
        {
            return _points[cardinal.ToString()];
        }

        public Point MoveTo(Point fromPoint, char toCardinal)
        {
            Point p = ToPoint(toCardinal);
            p.Offset(fromPoint.X, fromPoint.Y);
            return p;
        }

        public Point MoveTo(Point fromPoint, Point toPoint)
        {
            toPoint.Offset(fromPoint.X, fromPoint.Y);
            return toPoint;
        }

        public int GetTotalPokemonsByCardinalPoint(string coords)
        {
            HashSet<string> hsPointPokemonsCollected = new HashSet<string>();

            Point point = CardinalPoints.ZERO;

            //The initial position already has a pokemon
            string strPoint = point.ToString();
            hsPointPokemonsCollected.Add(strPoint);

            foreach (char cardinal in coords)
            {
                //Check if has invalid movement
                if (!Valid(cardinal))
                {
                    //If has invalid movement, exit with value -1
                    return -1;
                }

                //Move to next coordinate
                point = MoveTo(point, cardinal);
                strPoint = point.ToString();

                //If there is no pokemon at that coordinate, add it
                if (!hsPointPokemonsCollected.Contains(strPoint))
                {
                    hsPointPokemonsCollected.Add(strPoint);
                }
            }

            //Returning the number of pokemons found
            return hsPointPokemonsCollected.Count;
        }
    }
}
