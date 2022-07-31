using AshProjeto.Model;
using System;
/*
------------------
Testes realizados:
------------------

Para testes é só usar o command prompt do Windows adicionando o parâmetro após o executável.
Exemplo: AshProjeto.exe NSEOOOSOSEEOO
1) SNSNSNSNSNENENENENENOOOOOOEEOOOSOOOENNNNEEEOOOOSOOSOSOSOOSOEOENNNNNNSNSNSNSNSNENENENENENOOOOOOEEOOOSOOOENNNNEEEOOOOSOOSOSOSOOSOEOENNNNNNSNSNSNSNSNENENENENENOOOOOOEEOOOSOOOENNNNEEEOOOOSOOSOSOSOOSOEOENNNNNNSNSNSNSNSNENENENENENOOOOOOEEOOOSOOOENNNNEEEOOOOSOOSOSOSOOSOEOENNNNNNSNSNSNSNSNENENENENENOOOOOOEEOOOSOOOENNNNEEEOOOOSOOSOSOSOOSOEOENNNNNNSNSNSNSNSNENENENENENOOOOOOEEOOOSOOOENNNNEEEOOOOSOOSOSOSOOSOEOENNNNNNSNSNSNSNSNENENENENENOOOOOOEEOOOSOOOENNNNEEEOOOOSOOSOSOSOOSOEOENNNNNNSNSNSNSNSNENENENENENOOOOOOEEOOOSOOOENNNNEEEOOOOSOOSOSOSOOSOEOENNNNNN = 370

2) NNSSNNNNGEEOOOOSOOOSH = Existem comandos inválidos

3) SNSNENENENENENOOO = 15

4) E = 2
*/

namespace AshProjeto
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string coords = "";
            //
            //If it is coming from prompt command.
            if (args.Length > 0)
            {
                //If has the first prompt command parameter
                if (args[0].Length > 0)
                {
                    //Change to uppercase chars If the user has inputted the coordinates with lowercase chars
                    coords = args[0].ToUpper();
                }
            }
            StartGame(coords);
            return;
        }

        private static void StartGame(string coords)
        {
            int total = 0;

            //Game introduction
            //Console.WriteLine("\n[Pokemon: apanhá-los todos]");
            //Console.WriteLine("Em um mundo cheio de Pokemons sua tarefa será capturá-los. Boa sorte!");
            Console.WriteLine("\nInforme a sequência de movimentos para capturá-los:");
            Console.WriteLine("Legenda: N (Norte), S (Sul), E (Este), O (Oeste)\n");
            Console.WriteLine("Ex: NSNSNNEEEEOOO\n");

            //If there is no coordinates
            if (coords.Length == 0)
            {
                coords = Console.ReadLine();
            }
            else
            {
                //If there is coordinates
                Console.WriteLine(coords);
            }
            //
            //If it has the initial moves only.
            if (coords.Length == 0)
            {
                ShowMsg("Informe os movimentos.");
                return;
            }
            //
            //Counting all moves in typed coordinates
            Coords pokemons = new Coords();
            total = pokemons.GetTotalPokemonsByCoords(coords);
            //If has some invalid move
            if (total == -1)
            {
                ShowMsg("\nMovimento inválido!");
                return;
            }
            //
            //Total pokemons collected
            ShowMsg(String.Format("\nPokemons: {0}", total));
            return;
        }

        private static void ShowMsg(string msg)
        {
            Console.WriteLine(msg);
            Console.WriteLine("Tecle ENTER para continuar...");
            Console.ReadLine();
            return;
        }
    }
}
