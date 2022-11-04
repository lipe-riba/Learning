using System.Collections.Generic;
using System.Windows;

namespace AshProjeto.Model
{
    public class CoordModel : ICoordModel
    {
        Coord coord = null;
        
        public CoordModel()
        {
            coord = new Coord();
        }

        public Point MoveTo(Point point, char cardinal)
        {
            Point p = coord.ToPoint(cardinal);
            p.Offset(point.X, point.Y);
            return p;
        }

        public Point GetPoint(char cardinal)
        {
            return coord.ToPoint(cardinal);
        }

        public int GetTotalPokemonsByCoords(string coords)
        {
            HashSet<string> hs = new HashSet<string>();

            //Initial position already has pokemon in that coordinate
            int ret = 1;
            Point point = Coord.ZERO;

            string strPoint = point.ToString();
            hs.Add(strPoint);

            foreach (char cardinal in coords)
            {
                //Check if has invalid move
                if (!coord.Valid(cardinal))
                {
                    //If has invalid move, exit with value -1
                    return -1;
                }

                //Move to next coordinate
                point = MoveTo(point, cardinal);
                strPoint = point.ToString();

                //Checking if that coordinate already exists
                bool hasPoint = hs.Contains(strPoint);

                //If it doesn't exist there is a pokemon over there 
                if (!hasPoint)
                {
                    //Storing coordinate
                    hs.Add(strPoint);
                    //Adding 1 pokemon
                    ret += 1;
                }
            }
            //Returrning the amount of pokemons found
            return ret;
        }
    }
}
