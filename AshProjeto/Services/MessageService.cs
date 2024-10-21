using System;

namespace AshProjeto.Services
{
    public class MessageService
    {
        public sealed void Show(string msg)
        {
            Console.WriteLine($"\n{msg}\nPress any key to continue...");
            Console.ReadLine();
        }
    }
}
