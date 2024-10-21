using AshProjeto.Models;
using AshProjeto.Services;
using System;

namespace AshProjeto
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string cardinalPointsArgs = "";
 
            Console.WriteLine("Type the sequence of movements to catch the pokemons:\n" +
                              "Key: N (North), S (South), E (East), O (West)" +
                              "\n\n" +
                              "eg: NSNSNNEEEEOOO\n");

            //If it is coming from prompt command.
            if (args.Length > 0)
            {
                //Change to uppercase chars If the user has inputted the coordinates with lowercase chars
                cardinalPointsArgs = args[0].ToUpper();
                Console.WriteLine(cardinalPointsArgs);
            }
            else
            {
                //If there are no coordinates
                cardinalPointsArgs = Console.ReadLine();
            }
 
            //If it has no initial movements
            if (cardinalPointsArgs.Length == 0)
            {
                MessageService.Show("Type the movements.");
                return;
            }

            //Counting all movements in typed coordinates
            CardinalPointsService model = new CardinalPointsService(new CardinalPoints());
            int total = model.GetTotalPokemonsByCardinalPoint(cardinalPointsArgs);

            //If has some invalid movements
            if (total == -1)
            {
                MessageService.Show("Invalid movement!");
                return;
            }

            //Total pokemons collected
            MessageService.Show(string.Format("Pokemons: {0}", total));
        }
    }
}
