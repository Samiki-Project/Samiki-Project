using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;
using Samiki_Tamaguchi.Extensions;

namespace Samiki_Tamaguchi
{
    public partial class Samiki
    {
        class Play
        {
            /// <summary>
            /// Game chosen to play with Samiki
            /// <para></para>
            /// By default it is checkers but can be defined when instantiating an Play class object
            /// </summary>
            private string Game { get; set; } = "Checkers";

            /// <summary>
            /// Method for choosing which game to play with Samiki
            /// </summary>
            /// <param name="game"></param>
            public void ChooseGame(string game)
            {
                if (game != null) this.Game = game;
            }

            /// <summary>
            /// Stores all played time
            /// </summary>
            private int timePlaying { get; set; }
            /// <summary>
            /// Stores the last Cycle of Plays
            /// </summary>
            private DateTime lastPlayCycle = DateTime.Now;
            /// <summary>
            /// Attribute to define how long she will be playing in each cycle
            /// </summary>
            private int intervalPlay = 10000;



            /// <summary>
            /// Method that initiates the function of playing with Samiki to increase your level of happiness and decrease (over time) your level of Hunger
            /// </summary>
            public void Start()
            {
                Console.WriteLine($"YAY! Glad you want to play with me {Program.YourName}!!");
                Console.WriteLine($"What are we gonna play with? This time it will be {Game}, right??");

                Timer PlayTimer = new Timer(intervalPlay)
                {
                    AutoReset = true
                };
                PlayTimer.Elapsed += StartPlaying;
                PlayTimer.Start();

                Console.WriteLine("When you get tired of playing you can go out by pressing any key!");
                Console.ReadKey(true);

            }
            /// <summary>
            /// Function to start the Loop of gaming with Samiki
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void StartPlaying(object sender, ElapsedEventArgs e)
            {
                Console.WriteLine($"Playing...");
                var PlayTime = DateTime.Now - lastPlayCycle;
                var subtraction = PlayTime.TotalSeconds;
                Hunger -= int.Parse(Convert.ToSingle(subtraction).ToString());
                Console.WriteLine($"My hunger now is in: {Hunger}");

                Random random = new Random();
                int increase = random.Next(30,40);
                Hapiness += increase;
                Console.WriteLine($"My hapiness now is in: {Hapiness}");

                this.timePlaying += int.Parse(Convert.ToSingle(subtraction).ToString());
            }
        }
    }
    
}
