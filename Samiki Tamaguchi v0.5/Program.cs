using System;
using System.Collections.Generic;
using System.Timers;

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
        static void Main(string[] args)
        {
            GameStarted();
        }
        /* static void Main(string[] args)
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
        */
        public static void StartGame()
        {
            Console.WriteLine($"Be Welcomeee... ehh...");
            Console.WriteLine($"What's your name?");
            Console.WriteLine($"1- Use default name");
            Console.WriteLine($"Or enter your name:");
            string option = Console.ReadLine();

            if (option.Length > 1) { YourName = option; }

            Console.WriteLine($"Right! Hello {YourName}!!");
            Console.WriteLine($"Be Welcome!");
            Console.WriteLine($"Do you want your dear Samiki to have the default name?");
            Console.WriteLine($"1- Use default name");
            Console.WriteLine($"Or enter the desired name:");
            string nameoption = Console.ReadLine();

            if (option.Length > 1)
            {
                Console.WriteLine($"Oooahh! What an amazing name!");
                Console.WriteLine($"One more thing: do you want her to be bipolar?");
                Console.WriteLine($"Y- Yes");
                Console.WriteLine($"N- No");
                ConsoleKeyInfo option2 = Console.ReadKey(true);

                switch (option2.KeyChar)
                {
                    case 'Y':
                    case 'y':
                        Console.WriteLine($"Ehh... Ok... Good Luck!");
                        Console.WriteLine($"One more thing, I promise it's the last! >.<");
                        Console.WriteLine($"Do you want her to be born with random happiness / hunger numbers?");
                        Console.WriteLine($"Y- Yes");
                        Console.WriteLine($"N- No");
                        ConsoleKeyInfo option3 = Console.ReadKey(true);
                        switch (option3.KeyChar)
                        {
                            case 'Y':
                            case 'y':
                                Samiki Samiki_chan = new Samiki(true)
                                {
                                    Name = nameoption,
                                    Bipolar = true
                                };
                                break;
                            case 'N':
                            case 'n':
                                Samiki Samiki_chan2 = new Samiki()
                                {
                                    Name = nameoption,
                                    Bipolar = true
                                };
                                break;
                            default:
                                throw new ArgumentException("Error: You must enter a valid answer!");
                        }

                        break;
                    case 'N':
                    case 'n':
                        Console.WriteLine($"I agree with you, bipolar people are complicated!");
                        Console.WriteLine($"One more thing, I promise it's the last! >.<");
                        Console.WriteLine($"Do you want her to be born with random happiness / hunger numbers?");
                        Console.WriteLine($"Y- Yes");
                        Console.WriteLine($"N- No");
                        ConsoleKeyInfo option4 = Console.ReadKey(true);
                        switch (option4.KeyChar)
                        {
                            case 'Y':
                            case 'y':
                                Samiki Samiki_chan = new Samiki(true)
                                {
                                    Name = nameoption
                                };
                                break;
                            case 'N':
                            case 'n':
                                Samiki Samiki_chan2 = new Samiki()
                                {
                                    Name = nameoption
                                };
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
                Console.WriteLine($"Okay! She will have the default name!");
                Console.WriteLine($"One more thing: do you want her to be bipolar?");
                Console.WriteLine($"Y- Yes");
                Console.WriteLine($"N- No");
                ConsoleKeyInfo option2 = Console.ReadKey(true);

                switch (option2.KeyChar)
                {
                    case 'Y':
                    case 'y':
                        Console.WriteLine($"Ehh... Ok... Good Luck!");
                        Console.WriteLine($"One more thing, I promise it's the last! >.<");
                        Console.WriteLine($"Do you want her to be born with random happiness / hunger numbers?");
                        Console.WriteLine($"Y- Yes");
                        Console.WriteLine($"N- No");
                        ConsoleKeyInfo option3 = Console.ReadKey(true);
                        switch (option3.KeyChar)
                        {
                            case 'Y':
                            case 'y':
                                Samiki Samiki_chan = new Samiki(true)
                                {
                                    Bipolar = true
                                };
                                break;
                            case 'N':
                            case 'n':
                                Samiki Samiki_chan2 = new Samiki()
                                {
                                    Bipolar = true
                                };
                                break;
                            default:
                                throw new ArgumentException("Error: You must enter a valid answer!");
                        }

                        break;
                    case 'N':
                    case 'n':
                        Console.WriteLine($"I agree with you, bipolar people are complicated!");
                        Console.WriteLine($"One more thing, I promise it's the last! >.<");
                        Console.WriteLine($"Do you want her to be born with random happiness / hunger numbers?");
                        Console.WriteLine($"Y- Yes");
                        Console.WriteLine($"N- No");
                        ConsoleKeyInfo option4 = Console.ReadKey(true);
                        switch (option4.KeyChar)
                        {
                            case 'Y':
                            case 'y':
                                Samiki Samiki_chan = new Samiki(true);
                                break;
                            case 'N':
                            case 'n':
                                Samiki Samiki_chan2 = new Samiki();
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

        public static void GameStarted()
        {
            string any = "";
            int i = 0;
            while (any != "S")
            {
                i++;
                Console.WriteLine($"Round number {i}:");

                Console.WriteLine("To Finish the Application Type 'S'");
                any = Console.ReadLine();
            }
        }
    }
}