using AshProjeto.Models;
using AshProjeto.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

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

            bool hasArgsViaPrompt = (args.Length > 0);
            if (hasArgsViaPrompt)
            {
                cardinalPointsArgs = args[0].ToUpper();
                Console.WriteLine(cardinalPointsArgs);
            }
            else
            {
                cardinalPointsArgs = Console.ReadLine();
            }

            bool hasNoInitialMovement = cardinalPointsArgs.IsEmpty();
            if (hasNoInitialMovement)
            {
                MessageService.Show("Type the movements.");
                return;
            }

            CardinalPointsService cardinalPointService = new CardinalPointsService(new CardinalPoints());
            IList<Point> points = cardinalPointService.ToPoints(cardinalPointsArgs);
            int totalPokemons = cardinalPointService.GetTotalPokemons(points);

            bool hasInvalidMovement = (totalPokemons == CardinalPointsService.COUNT_ERROR);
            if (hasInvalidMovement)
            {
                MessageService.Show("Invalid movement!");
                return;
            }

            MessageService.Show(string.Format("Pokemons: {0}", totalPokemons));
        }
    }
}
