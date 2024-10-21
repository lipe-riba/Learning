using AshProjeto.Models;
using AshProjeto.Services;
using System;

namespace AshProjeto
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string cardinalPoints = "";
            MessageService message = new MessageService();

            Console.WriteLine("Type the sequence of movements to catch the pokemons:\n" +
                              "Key: N (North), S (South), E (East), O (West)" +
                              "\n\n" +
                              "eg: NSNSNNEEEEOOO\n" +
                              $"{cardinalPoints}");

            //If it is coming from prompt command.
            if (args.Length > 0)
            {
                //Change to uppercase chars If the user has inputted the coordinates with lowercase chars
                cardinalPoints = args[0].ToUpper();
                Console.WriteLine(cardinalPoints);
            }
            else
            {
                //If there are no coordinates
                cardinalPoints = Console.ReadLine();
            }
 
            //If it has no initial movements
            if (cardinalPoints.Length == 0)
            {
                message.Show("Type the movements.");
                return;
            }

            //Counting all movements in typed coordinates
            CardinalPointsService model = new CardinalPointsService();
            int total = model.GetTotalPokemonsByCardinalPoint(cardinalPoints);

            //If has some invalid movements
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
