using AshProjeto.Model;
using AshProjeto.Services;
using System;

namespace AshProjeto
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string coords = "";
            Message message = new Message();

            Console.WriteLine("Type the sequence of movements to catch the pokemons:\n" +
                              "Key: N (North), S (South), E (East), O (West)" +
                              "\n\n" +
                              "eg: NSNSNNEEEEOOO\n" +
                              $"{coords}");

            //If it is coming from prompt command.
            if (args.Length > 0)
            {
                //Change to uppercase chars If the user has inputted the coordinates with lowercase chars
                coords = args[0].ToUpper();
                Console.WriteLine(coords);
            }
            else
            {
                //If there are no coordinates
                coords = Console.ReadLine();
            }
 
            //If it has the initial moves only.
            if (coords.Length == 0)
            {
                message.Show("Type the movements.");
                return;
            }

            //Counting all moves in typed coordinates
            CoordModel model = new CoordModel();
            int total = model.GetTotalPokemonsByCoords(coords);

            //If has some invalid move
            if (total == -1)
            {
                message.Show("Invalid movement!");
                return;
            }

            //Total pokemons collected
            message.Show(string.Format("Pokemons: {0}", total));
        }
    }
}
