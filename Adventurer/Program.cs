using System;

namespace Adventurer
{
    class Program
    {
        static void Main()
        {
            string CharacterName = "John Doe";

            Console.WriteLine("Askeer Bay");
            Console.WriteLine("Welcome to the bay of Askeer. You will be exploring the town and discover many things");
            Console.WriteLine("What should we call you ?");
            CharacterName = Console.ReadLine();
            Console.WriteLine("Owh, that's a first. Right, we'll call you " + CharacterName);
            Console.Read();
        }
    }
}
