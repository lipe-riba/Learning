using System;
using System.Collections.Generic;

namespace AshProjeto.Model
{
    public class Coords
    {
        public int GetTotalPokemonsByCoords(String coords)
        {
            HashSet<String> hs = new HashSet<String>();
            Coord position = new Coord();
            String strCoord = "";
            int ret = 0;
            //
            //Initial position already has pokemon in that coordinate
            strCoord = position.ToString(); //0:0
            hs.Add(strCoord);
            ret = 1;
            // 
            bool hasCoord = false;
            foreach (char c in coords)
            {
                //Check if has invalid move
                if ("NSEO".IndexOf(c) == -1)
                {
                    //If has invalid move, exit with value -1
                    return -1;
                }
                //
                //Move to next coordinate
                position.move(c);
                strCoord = position.ToString();
                //Checking if that coordinate already exists
                hasCoord = hs.Contains(strCoord);
                //If it doesn't exist there is a pokemon over there 
                if (!hasCoord)
                {
                    //Storing coordinate
                    hs.Add(strCoord);
                    //Adding 1 pokemon
                    ret += 1;
                }
            }
            //Returrning the amount of pokemons found
            return ret;
        }
    }
}