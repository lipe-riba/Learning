using AshProjeto.Model;
using System;

namespace AshProjeto
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string coords = "";
            //If it is coming from prompt command.
            if (string.Join("", args).Length > 0)
            {
                //Change to uppercase chars If the user has inputted the coordinates with lowercase chars
                coords = args[0].ToUpper();
            }
            StartGame(coords);
        }

        private static void StartGame(string coords)
        {
            Console.WriteLine("Type the sequence of movements to catch them:");
            Console.WriteLine("Key: N (North), S (South), E (East), O (West)\n");
            Console.WriteLine("eg: NSNSNNEEEEOOO\n");

            //If there is no coordinates
            if (coords.Length == 0)
            {
                coords = Console.ReadLine();
            }
            else
            {
                //If coordinates was typed from command prompt
                Console.WriteLine(coords);
            }

            Message message = new Message();

            //If it has the initial moves only.
            if (coords.Length == 0)
            {
                message.Show("Type the movements.");
                return;
            }

            //Counting all moves in typed coordinates
            Coords pokemons = new Coords();
            int total = pokemons.GetTotalPokemonsByCoords(coords);

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
