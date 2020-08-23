using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace Samiki_Tamaguchi
{
    public partial class Samiki
    {

        class Eat
        {
            /// <summary>
            /// Food chosen to Samiki eats
            /// <para></para>
            /// By default it is Chicken but can be defined when instantiating an Eat class object
            /// </summary>
            private string Food { get; set; } = "Chicken";
            /// <summary>
            /// Stores the last Cycle of Eats
            /// </summary>
            private DateTime lastEatCycle = DateTime.Now;
            /// <summary>
            /// Attribute to define how long she will be eating in each cycle
            /// </summary>
            private int intervalEat = 10000;

            /// <summary>
            ///  Method for choosing which Food Samiki will eat
            /// </summary>
            /// <param name="food"></param>
            public void ChooseFood(string food)
            {
                if (food != null) this.Food = food;
            }

            /// <summary>
            /// Method that initiates the function of eating with Samiki to increase your level of Hunger and decrease (over time) your level of Hapiness
            /// </summary>
            public void Start()
            {
                Console.WriteLine($"YAY! Glad you want to feed me {Program.YourName}!!");
                Console.WriteLine($"What are we gonna eat? This time it will be {Food}, right??");

                Timer PlayTimer = new Timer(intervalEat)
                {
                    AutoReset = true
                };
                PlayTimer.Elapsed += StartEating;
                PlayTimer.Start();

                Console.WriteLine("When you get tired of eating you can go out by pressing any key!");
                Console.ReadKey(true);

            }
            /// <summary>
            /// Function to start the Loop of Eating with Samiki
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void StartEating(object sender, ElapsedEventArgs e)
            {
                Console.WriteLine($"Eating...");
                var PlayTime = DateTime.Now - lastEatCycle;
                var subtraction = PlayTime.TotalSeconds;
                Hapiness -= int.Parse(Convert.ToSingle(subtraction).ToString());
                Console.WriteLine($"My hapiness now is in: {Hapiness}");
                

                Random random = new Random();
                int increase = random.Next(5, 10);
                Hunger += increase;
                Console.WriteLine($"My hunger now is in: {Hunger}");
            }



        }

    }
}
