using System.Collections.Generic;
using System.Windows;

namespace AshProjeto.Model
{
    public class CoordModel : ICoordModel
    {
        Coord _coord = null;

        private Dictionary<string, Point> _points;

        public CoordModel()
        {
            _coord = new Coord();
            _points = new Dictionary<string, Point>()
            {
                {"N", _coord.N },
                {"S", _coord.S },
                {"E", _coord.E },
                {"O", _coord.O }
            };
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

        public int GetTotalPokemonsByCoords(string coords)
        {
            HashSet<string> hsPointPokemonsCollected = new HashSet<string>();

            Point point = _coord.ZERO;

            //The initial position already has a pokemon
            string strPoint = point.ToString();
            hsPointPokemonsCollected.Add(strPoint);

            foreach (char cardinal in coords)
            {
                //Check if has invalid move
                if (!Valid(cardinal))
                {
                    //If has invalid move, exit with value -1
                    return -1;
                }

                //Move to next coordinate
                point = MoveTo(point, cardinal);
                strPoint = point.ToString();

                //If it doesn't exist there is a pokemon over there 
                if (!hsPointPokemonsCollected.Contains(strPoint))
                {
                    //Storing coordinate
                    hsPointPokemonsCollected.Add(strPoint);
                }
            }

            //Returning the amount of pokemons found
            return hsPointPokemonsCollected.Count;
        }
    }
}
