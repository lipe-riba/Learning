using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AshProjeto
{
    public class Coords
    {
        public class Coord
        {
            public int X;
            public int Y;

	    public void move(char position) 
            {
                switch (position)
                {
                    case 'N':
                        this.X -= 1;
                        break;
                    case 'S':
                        this.X += 1;
                        break;
                    case 'E':
                        this.Y += 1;
                        break;
                    case 'O':
                        this.Y -= 1;
                        break;
                }
                return;
            }

            public override string ToString()
            {
                return X.ToString() + ":" + Y.ToString();
            }
        }

       public int GetTotalPokemonsByCoords(String coords)
        {
            HashSet<String> hs = new HashSet<String>();
            Coord position = new Coord();
            String strCoord = ""; 
            int ret = 0;
            //
            //Initial position already has pokemon in that coord
            strCoord = position.ToString();
            hs.Add(strCoord);    
            ret = 1;
            // 
            bool hasCoord = false; 
            foreach (char c in coords)
            {
                //Check if has invalid move
                if ("NSEO".IndexOf(c) == -1)
                {
                    //If has, exit with value -1
                    return -1;
                }
                //
                //Move to next coord
                position.move(c);
                strCoord = position.ToString();
                //Checking if that coord already exists
                hasCoord = hs.Contains(strCoord);
                //If not exists, add in hashset
                if (!hasCoord)
                {
                    //Registering coord
                    hs.Add(strCoord);
                    //Add more 1
                    ret += 1;           
                }
            }
            //
            return ret;
        }
    }
}
