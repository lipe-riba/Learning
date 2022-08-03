using System;

namespace AshProjeto.Model
{
    internal class Message
    {
        internal void Show(string msg)
        {
            Console.WriteLine("\n" + msg);
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    }
}
