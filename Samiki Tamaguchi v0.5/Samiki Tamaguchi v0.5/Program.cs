using System;
using Samiki_Tamaguchi.Events;

namespace Samiki_Tamaguchi
{
    class Program
    {

        /// <summary>
        /// Main Character's Name
        /// <para></para>
        /// By default it is "Akira Mizushima", but can be customized.
        /// </summary>
        public static string YourName { get; set; } = "Akira Mizushima";
        /// <summary>
        /// A static field with the name of Samiki to be able to obtain this reference in other files
        /// </summary>
        public static string SamikiName { get; set; }
        /// <summary>
        /// A static field with the Hunger Level of Samiki to be able to obtain this reference in other files
        /// </summary>
        public static int SamikiHunger { get; set; }
        /// <summary>
        /// A static field with the Hapiness Level of Samiki to be able to obtain this reference in other files
        /// </summary>
        public static int SamikiHapiness { get; set; }
        /// <summary>
        /// A static field with the Health Level of Samiki to be able to obtain this reference in other files
        /// </summary>
        public static int SamikiHealth { get; set; }


        static void Main(string[] args)
        {
            Console.WriteLine($"HI! My name is Mya-nee and I will assist you today!");
            Console.WriteLine("Welcome to Samiki Tamaguchi v0.5 \nIt's a pleasure to have you with us!");
            Console.WriteLine("Do you want to start?");
            Console.WriteLine($"Y- Yes");
            Console.WriteLine($"N- No");
            ConsoleKeyInfo option = Console.ReadKey(true);

            switch (option.KeyChar)
            {
                case 'Y':
                case 'y':
                    StartGame();
                    break;
                case 'N':
                case 'n':
                    Console.WriteLine("Ok, see you soon!");
                    break;
                default:
                    throw new ArgumentException("Error: You must enter a valid answer!");
            }
        }

        /// <summary>
        /// Starts the game With the User preferences!
        /// <para></para>
        /// Generates an execution of the method <see cref="GameStarted(string, bool, bool)"/>
        /// </summary>
        public static void StartGame()
        {
            Console.WriteLine($"\nBe Welcomeee... ehh...");
            Console.WriteLine($"What's your name?");
            Console.WriteLine($"1- Use default name");
            Console.WriteLine($"Or enter your name:");
            string option = Console.ReadLine();

            if (option.Length > 1) { YourName = option; }

            Console.WriteLine($"\nRight! Hello {YourName}!!");
            Console.WriteLine($"Be Welcome!");
            Console.WriteLine($"Do you want your dear Samiki to have the default name?");
            Console.WriteLine($"1- Use default name");
            Console.WriteLine($"Or enter the desired name:");
            string nameoption = Console.ReadLine();

            if (option.Length > 1)
            {
                Console.WriteLine($"\nOooahh! What an amazing name!");
                Console.WriteLine($"One more thing: do you want her to be bipolar?");
                Console.WriteLine($"Y- Yes");
                Console.WriteLine($"N- No");
                ConsoleKeyInfo option2 = Console.ReadKey(true);

                switch (option2.KeyChar)
                {
                    case 'Y':
                    case 'y':
                        Console.WriteLine($"\nEhh... Ok... Good Luck!");
                        Console.WriteLine($"One more thing, I promise it's the last! >.<");
                        Console.WriteLine($"Do you want her to be born with random happiness / hunger numbers?");
                        Console.WriteLine($"Y- Yes");
                        Console.WriteLine($"N- No");
                        ConsoleKeyInfo option3 = Console.ReadKey(true);
                        switch (option3.KeyChar)
                        {
                            case 'Y':
                            case 'y':
                                GameStarted(nameoption, true, true);
                                break;
                            case 'N':
                            case 'n':
                                GameStarted(nameoption, true);
                                break;
                            default:
                                throw new ArgumentException("Error: You must enter a valid answer!");
                        }

                        break;
                    case 'N':
                    case 'n':
                        Console.WriteLine($"\nI agree with you, bipolar people are complicated!");
                        Console.WriteLine($"One more thing, I promise it's the last! >.<");
                        Console.WriteLine($"Do you want her to be born with random happiness / hunger numbers?");
                        Console.WriteLine($"Y- Yes");
                        Console.WriteLine($"N- No");
                        ConsoleKeyInfo option4 = Console.ReadKey(true);
                        switch (option4.KeyChar)
                        {
                            case 'Y':
                            case 'y':
                                GameStarted(nameoption, false, true);
                                break;
                            case 'N':
                            case 'n':
                                GameStarted(nameoption);
                                break;
                            default:
                                throw new ArgumentException("Error: You must enter a valid answer!");
                        }
                        break;
                    default:
                        throw new ArgumentException("Error: You must enter a valid answer!");
                }
            }
            else
            {
                Console.WriteLine($"\nOkay! She will have the default name!");
                Console.WriteLine($"One more thing: do you want her to be bipolar?");
                Console.WriteLine($"Y- Yes");
                Console.WriteLine($"N- No");
                ConsoleKeyInfo option2 = Console.ReadKey(true);

                switch (option2.KeyChar)
                {
                    case 'Y':
                    case 'y':
                        Console.WriteLine($"\nEhh... Ok... Good Luck!");
                        Console.WriteLine($"One more thing, I promise it's the last! >.<");
                        Console.WriteLine($"Do you want her to be born with random happiness / hunger numbers?");
                        Console.WriteLine($"Y- Yes");
                        Console.WriteLine($"N- No");
                        ConsoleKeyInfo option3 = Console.ReadKey(true);
                        switch (option3.KeyChar)
                        {
                            case 'Y':
                            case 'y':
                                GameStarted(default, true, true);
                                break;
                            case 'N':
                            case 'n':
                                GameStarted(default, true);
                                break;
                            default:
                                throw new ArgumentException("Error: You must enter a valid answer!");
                        }

                        break;
                    case 'N':
                    case 'n':
                        Console.WriteLine($"\nI agree with you, bipolar people are complicated!");
                        Console.WriteLine($"One more thing, I promise it's the last! >.<");
                        Console.WriteLine($"Do you want her to be born with random happiness / hunger numbers?");
                        Console.WriteLine($"Y- Yes");
                        Console.WriteLine($"N- No");
                        ConsoleKeyInfo option4 = Console.ReadKey(true);
                        switch (option4.KeyChar)
                        {
                            case 'Y':
                            case 'y':
                                GameStarted(default, false, true);
                                break;
                            case 'N':
                            case 'n':
                                GameStarted();
                                break;
                            default:
                                throw new ArgumentException("Error: You must enter a valid answer!");
                        }
                        break;
                    default:
                        throw new ArgumentException("Error: You must enter a valid answer!");
                }
            }
        }

        /// <summary>
        /// Creates an instance for <see cref="Samiki"/> to create life and the game to start
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="bipolar"></param>
        /// <param name="random"></param>
        public static void GameStarted(string name = default, bool bipolar = false, bool random = false)
        {
            Samiki Samiki_chan;

            if (name != default)
            {
                if (bipolar)
                {
                    if (random)
                    {
                        Samiki_chan = new Samiki(true)
                        {
                            Name = name,
                            Bipolar = true
                        };
                    }
                    else
                    {
                        Samiki_chan = new Samiki()
                        {
                            Name = name,
                            Bipolar = true
                        };
                    }

                }
                else
                {
                    if (random)
                    {
                        Samiki_chan = new Samiki(true) { Name = name };
                    }
                    else
                    {
                        Samiki_chan = new Samiki() { Name = name };
                    }
                }
            }
            else
            {
                if (bipolar)
                {
                    if (random)
                    {
                        Samiki_chan = new Samiki(true) { Bipolar = true };
                    }
                    else
                    {
                        Samiki_chan = new Samiki() { Bipolar = true };
                    }
                }
                else
                {
                    if (random)
                    {
                        Samiki_chan = new Samiki(true);
                    }
                    else
                    {
                        Samiki_chan = new Samiki();
                    }
                }
            }

            SamikiName = Samiki_chan.Name;
            SamikiHapiness = Samiki_chan.Hapiness;
            SamikiHunger = Samiki_chan.Hunger;
            SamikiHealth = Samiki_chan.Health;

            Eat eat = new Eat();
            Play play = new Play();

            int i = 0;
            string any = "";
            while (any != "S")
            {
                i++;
                Console.WriteLine($"Round number {i}:");

                Console.WriteLine($"");
                Console.WriteLine("What do you want to do?");
                Console.WriteLine($"A- Eat");
                Console.WriteLine($"B- Play");
                Console.WriteLine($"C- Nothing");
                Console.WriteLine($"");
                Console.WriteLine("To Finish the Application Type 'S'");
                any = Console.ReadLine();

                switch (any)
                {
                    case "A":
                    case "a":
                        Console.WriteLine($"Does she want to eat something other than normal?");
                        Console.WriteLine($"Y- Yes");
                        Console.WriteLine($"N- No");
                        ConsoleKeyInfo opt = Console.ReadKey(true);

                        switch (opt.KeyChar)
                        {
                            case 'Y':
                            case 'y':
                                Console.WriteLine($"What she Want to eat?");
                                eat.ChooseFood(Console.ReadLine());
                                eat.Start();
                                break;
                            case 'N':
                            case 'n':
                                eat.Start();
                                break;
                            default:
                                throw new ArgumentException("Error: You must enter a valid answer!");
                        }
                        break;
                    case "B":
                    case "b":
                        Console.WriteLine($"Does she want to play something other than normal?");
                        Console.WriteLine($"Y- Yes");
                        Console.WriteLine($"N- No");
                        ConsoleKeyInfo opt2 = Console.ReadKey(true);

                        switch (opt2.KeyChar)
                        {
                            case 'Y':
                            case 'y':
                                Console.WriteLine($"What she Want to play?");
                                play.ChooseGame(Console.ReadLine());
                                Console.WriteLine($"");
                                play.Start();
                                Console.WriteLine($"");
                                break;
                            case 'N':
                            case 'n':
                                Console.WriteLine($"");
                                play.Start();
                                Console.WriteLine($"");
                                break;
                            default:
                                throw new ArgumentException("Error: You must enter a valid answer!");
                        }
                        break;
                    case "C":
                    case "c":
                        Console.WriteLine($"Okay, let's go to another Round");
                        break;
                    case "S":
                        Console.WriteLine($"Okay, bye then!~");
                        break;
                    default:
                        throw new ArgumentException("Error: You must enter a valid answer!");
                }
                if (bipolar) { Samiki_chan.StartBipolar(); Console.WriteLine($""); }
                else { Samiki_chan.StartNormal(); Console.WriteLine($""); }

                SamikiHapiness = Samiki_chan.Hapiness;
                SamikiHunger = Samiki_chan.Hunger;
                SamikiHealth = Samiki_chan.Health;
            }
        }
    }
}