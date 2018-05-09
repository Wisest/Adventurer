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
        static int Scenes = 1;
        static string[] PartOne = {
            //1----------------------------------------------------------------------------
            // [0]
            @"You have walked a great deal before arriving at the doors of Askeer.
The wall of the city were looking kind of old, but without damage.
As you approach the West gate, behind a small market made of merchants and some poor beggars you notice a guard point.
Making your way to the guard point through the little market, a beggar stop you and ask for a coin to eat.
            A – Give some coins to the beggar and continue to the guard point
            B – Give nothing the beggar and continue to the guard point",
            //A
            // [1]
            @"As you let your hand into your money bag, the eyes of the beggar brighten up and compliment his non hidden smile.
  ""It\'s not often that a stranger stop by. You should mind the guard and find another entrance.
Let me help you with that as a thanks for the money you gave me"".
And so the beggar start leading you to a smaller guarded entrance, where the city wall is in maintenance.
He introduces you with one of the worker, and after a bit of climbing the wooden scaffolding up and down, you finally find yourself inside the city.",
            //B
            // [2]
            @"You don't feel it would be fair to give to one beggar and not to the other. So you just give him a proper greetings and continue to the guard point.
As you try to pass the guard, one of them stop you : ""Hey, you ! What's your business in Askeer ?""
You don't really want to answer him, and just run out of it. You have to force your way but soon you are out of their sight.
As you hear the guards shouts getting weaker, you stop running. You are in the city.",
            //2----------------------------------------------------------------------------
            // [3]
            @"The guards, not just the one from the West gate, seems agitated and you want to know why.
After walking less than ten minutes you are near the center of the town, where rich merchants and proficients crafters sells their goods.
You see a wine dealer on your right, and a instrument maker on your left.
            A - You decide to talk to the wine dealer.
            B - You decide to talk to the instrument maker.",
            //A
            // [4]
            @"You decide to buy a bottle of wine, and ask genuinely about the guard being on edge.
""Tell me about it"", says the wine dealer. ""Since the incident the other day, they don't let us merchants in that easily.
They search every carts entering the city. Of course, give them a bottle or two, and it smooth things over, but it's ruining my business !\",
            //B
            // [5]
            @"You great the instrument maker, who don't even look at you as he is closing a deal with a bard.
It's natural for bard to be well informed about the last news, you think. As soon as the bard leave the shop, you catch up with him and start asking him about the last big news.
""Well, there was this big incident three days ago. Fire everywhere, and people screaming around.
I'm sure it's the main story of every bards in the region. But me, I have better story to tell, I come from Val Tereigne Bard's Academia.\",
            //3----------------------------------------------------------------------------
            // [6]
            "You want to ask more questions about the incident but you notice a group of guard coming your way."};
        static string[] PartTwo = {
            //1----------------------------------------------------------------------------
            // [0]
            @"You have walked a great deal before arriving at the doors of Askeer.
The wall of the city were looking kind of old, but without damage.
As you approach the West gate, behind a small market made of merchants and some poor beggars you notice a guard point.
Making your way to the guard point through the little market, a beggar stop you and ask for a coin to eat.
            A – Give some coins to the beggar and continue to the guard point
            B – Give nothing the beggar and continue to the guard point",
            //A
            // [1]
            @"As you let your hand into your money bag, the eyes of the beggar brighten up and compliment his non hidden smile.
  ""It\'s not often that a stranger stop by. You should mind the guard and find another entrance.
Let me help you with that as a thanks for the money you gave me"".
And so the beggar start leading you to a smaller guarded entrance, where the city wall is in maintenance.
He introduces you with one of the worker, and after a bit of climbing the wooden scaffolding up and down, you finally find yourself inside the city.",
            //B
            // [2]
            @"You don't feel it would be fair to give to one beggar and not to the other. So you just give him a proper greetings and continue to the guard point.
As you try to pass the guard, one of them stop you : ""Hey, you ! What's your business in Askeer ?""
You don't really want to answer him, and just run out of it. You have to force your way but soon you are out of their sight.
As you hear the guards shouts getting weaker, you stop running. You are in the city.",
            //2----------------------------------------------------------------------------
            // [3]
            @"The guards, not just the one from the West gate, seems agitated and you want to know why.
After walking less than ten minutes you are near the center of the town, where rich merchants and proficients crafters sells their goods.
You see a wine dealer on your right, and a instrument maker on your left.
            A - You decide to talk to the wine dealer.
            B - You decide to talk to the instrument maker.",
            //A
            // [4]
            @"You decide to buy a bottle of wine, and ask genuinely about the guard being on edge.
""Tell me about it"", says the wine dealer. ""Since the incident the other day, they don't let us merchants in that easily.
They search every carts entering the city. Of course, give them a bottle or two, and it smooth things over, but it's ruining my business !\",
            //B
            // [5]
            @"You great the instrument maker, who don't even look at you as he is closing a deal with a bard.
It's natural for bard to be well informed about the last news, you think. As soon as the bard leave the shop, you catch up with him and start asking him about the last big news.
""Well, there was this big incident three days ago. Fire everywhere, and people screaming around.
I'm sure it's the main story of every bards in the region. But me, I have better story to tell, I come from Val Tereigne Bard's Academia.\",
            //3----------------------------------------------------------------------------
            // [6]
            "You want to ask more questions about the incident but you notice a group of guard coming your way."};
        static string[] PartTrhee = {
            //1----------------------------------------------------------------------------
            // [0]
            @"You have walked a great deal before arriving at the doors of Askeer.
The wall of the city were looking kind of old, but without damage.
As you approach the West gate, behind a small market made of merchants and some poor beggars you notice a guard point.
Making your way to the guard point through the little market, a beggar stop you and ask for a coin to eat.
            A – Give some coins to the beggar and continue to the guard point
            B – Give nothing the beggar and continue to the guard point",
            //A
            // [1]
            @"As you let your hand into your money bag, the eyes of the beggar brighten up and compliment his non hidden smile.
  ""It\'s not often that a stranger stop by. You should mind the guard and find another entrance.
Let me help you with that as a thanks for the money you gave me"".
And so the beggar start leading you to a smaller guarded entrance, where the city wall is in maintenance.
He introduces you with one of the worker, and after a bit of climbing the wooden scaffolding up and down, you finally find yourself inside the city.",
            //B
            // [2]
            @"You don't feel it would be fair to give to one beggar and not to the other. So you just give him a proper greetings and continue to the guard point.
As you try to pass the guard, one of them stop you : ""Hey, you ! What's your business in Askeer ?""
You don't really want to answer him, and just run out of it. You have to force your way but soon you are out of their sight.
As you hear the guards shouts getting weaker, you stop running. You are in the city.",
            //2----------------------------------------------------------------------------
            // [3]
            @"The guards, not just the one from the West gate, seems agitated and you want to know why.
After walking less than ten minutes you are near the center of the town, where rich merchants and proficients crafters sells their goods.
You see a wine dealer on your right, and a instrument maker on your left.
            A - You decide to talk to the wine dealer.
            B - You decide to talk to the instrument maker.",
            //A
            // [4]
            @"You decide to buy a bottle of wine, and ask genuinely about the guard being on edge.
""Tell me about it"", says the wine dealer. ""Since the incident the other day, they don't let us merchants in that easily.
They search every carts entering the city. Of course, give them a bottle or two, and it smooth things over, but it's ruining my business !\",
            //B
            // [5]
            @"You great the instrument maker, who don't even look at you as he is closing a deal with a bard.
It's natural for bard to be well informed about the last news, you think. As soon as the bard leave the shop, you catch up with him and start asking him about the last big news.
""Well, there was this big incident three days ago. Fire everywhere, and people screaming around.
I'm sure it's the main story of every bards in the region. But me, I have better story to tell, I come from Val Tereigne Bard's Academia.\",
            //3----------------------------------------------------------------------------
            // [6]
            "You want to ask more questions about the incident but you notice a group of guard coming your way."};

        public static void StartGame()
        {
            GameTitle();
            NameCharacter();
            Choice();
            EndGame();
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
            for (int scenario = 1; scenario <= Scenes; scenario++)
            { 
                string input = "";

                switch (scenario)
                {
                    case 1:
                        //Part One
                        //write the beginning of the scenario 
                        //and ask for a choice between a or b
                        Console.WriteLine(PartOne[0]);

                        //read in the choice and save it
                        input = Console.ReadLine();
                        //make whatever was typed in lowercase
                        //    we could also use ToUpper() and then 
                        //    capitalize the A and B in the if statements 
                        //    either way it allows the player to type in lower or capital letters 
                        input = input.ToLower();
                        //if the choice was a, print out the second element in the array [1]
                        if (input == "a")
                        {
                            Console.WriteLine(PartOne[1]);
                        }

                        //if the player types b (or anything else) we'll assume they want the second choice
                        else
                        {
                            Console.WriteLine(PartOne[2]);
                        }

                        //write out the next part of the story for everyone
                        Console.WriteLine(PartOne[3]);
                
                        //read in the choice and save it
                        input = Console.ReadLine();

                        //if the choice was a, print out the second element in the array [4]
                        if (input == "a")
                        {
                            Console.WriteLine(PartOne[4]);

                        }
                        else
                        {
                            Console.WriteLine(PartOne[5]);
                        }

                        //write out the transition to the next part of the story for everyone
                        Console.WriteLine(PartOne[6]);
                        break;

                    case 2:
                        //Part Two
                        //write the beginning of the scenario 
                        //and ask for a choice between a or b
                        Console.WriteLine(PartTwo[0]);

                        //read in the choice and save it
                        input = Console.ReadLine();
                        //make whatever was typed in lowercase
                        //    we could also use ToUpper() and then 
                        //    capitalize the A and B in the if statements 
                        //    either way it allows the player to type in lower or capital letters 
                        input = input.ToLower();
                        //if the choice was a, print out the second element in the array [1]
                        if (input == "a")
                        {
                            Console.WriteLine(PartTwo[1]);
                        }

                        //if the player types b (or anything else) we'll assume they want the second choice
                        else
                        {
                            Console.WriteLine(PartTwo[2]);
                        }

                        //write out the next part of the story for everyone
                        Console.WriteLine(PartTwo[3]);

                        //read in the choice and save it
                        input = Console.ReadLine();

                        //if the choice was a, print out the second element in the array [4]
                        if (input == "a")
                        {
                            Console.WriteLine(PartTwo[4]);

                        }
                        else
                        {
                            Console.WriteLine(PartTwo[5]);
                        }

                        //write out the transition to the next part of the story for everyone
                        Console.WriteLine(PartTwo[6]);
                        break;

                    case 3:
                        //Part One
                        //write the beginning of the scenario 
                        //and ask for a choice between a or b
                        Console.WriteLine(PartThree[0]);

                        //read in the choice and save it
                        input = Console.ReadLine();
                        //make whatever was typed in lowercase
                        //    we could also use ToUpper() and then 
                        //    capitalize the A and B in the if statements 
                        //    either way it allows the player to type in lower or capital letters 
                        input = input.ToLower();
                        //if the choice was a, print out the second element in the array [1]
                        if (input == "a")
                        {
                            Console.WriteLine(PartThree[1]);
                        }

                        //if the player types b (or anything else) we'll assume they want the second choice
                        else
                        {
                            Console.WriteLine(PartThree[2]);
                        }

                        //write out the next part of the story for everyone
                        Console.WriteLine(PartThree[3]);

                        //read in the choice and save it
                        input = Console.ReadLine();

                        //if the choice was a, print out the second element in the array [4]
                        if (input == "a")
                        {
                            Console.WriteLine(PartThree[4]);

                        }
                        else
                        {
                            Console.WriteLine(PartThree[5]);
                        }

                        //write out the transition to the next part of the story for everyone
                        Console.WriteLine(PartThree[6]);
                        break;

                    default:
                        //default if section number does not match one of the above
                        break;
                }
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
        static void EndGame()
        {
            Console.WriteLine("Press Enter to exit");
            Console.ReadKey();
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
