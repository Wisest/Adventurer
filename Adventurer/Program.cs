/* Askeer
 * by MrWisest, 5 May 2018
 * 
 * This work is a derivative of
 * "C# Adventure Game" by http://programmingisfun.com, used under CC BY.
 * https://creativecommons.org/licenses/by/4.0/
 */
using System;

namespace Adventurer
{
    static class Game
    {
        static string CharacterName;

        //print out game title and overview

        public static void StartGame()
        {
            GameTitle();
            NameCharacter();
            Choice();
        }
        //ask player for a name, and save it
        static void NameCharacter()
        {
            Console.WriteLine("What should we call you ?");
            CharacterName = Console.ReadLine();
            Console.WriteLine("Owh, that's a first. Right, we'll call you " + CharacterName);
        }
        static void Dialog(string message, string color)
        {
            if (color == "red")
            { Console.ForegroundColor = ConsoleColor.Red; }
            else if (color == "green")
            { Console.ForegroundColor = ConsoleColor.Green; }
            else if (color == "cyan")
            { Console.ForegroundColor = ConsoleColor.Cyan; }
            else
            { Console.ForegroundColor = ConsoleColor.White; }

            Console.WriteLine(message);
            Console.ResetColor();
        }
        static void Choice()
        {
            string input = "";
            Console.WriteLine(CharacterName + " which path will you choose? A or B?");
            input = Console.ReadLine();
            if (input.ToLower() == "a")
            {
                Console.WriteLine("You've chosen path A!");
            }
            else
            {
                Console.WriteLine("You've chosen path B!");
            }
        }
        static void GameTitle()
        {
            string TitleScreen = @"        _____          __                         __________               
       /  _  \   _____|  | __ ____   ___________  \______   \_____  ___.__.
      /  /_\  \ /  ___/  |/ // __ \_/ __ \_  __ \  |    |  _/\__  \<   |  |
     /    |    \\___ \|    <\  ___/\  ___/|  | \/  |    |   \ / __ \\___  |
     \____|__  /____  >__|_ \\___  >\___  >__|     |______  /(____  / ____|
             \/     \/     \/    \/     \/                \/      \/\/     ";
            Console.Title = "Askeer Bay - Legend of the old town";
            Dialog(TitleScreen, "cyan");
            Console.WriteLine("\nBy MrWisest - Edited by Coffee Game Factory");
            Console.WriteLine("\nWelcome to the bay of Askeer. You will be exploring the old town and discover it's story");
            Console.WriteLine("Press Enter to continue");
            Console.ReadKey();
            Console.Clear();
        }


    }
    class Item
    {

    }
    class Program
    {
        static void Main()
        {
            Game.StartGame();
            Console.Read();
        }
    }
}
