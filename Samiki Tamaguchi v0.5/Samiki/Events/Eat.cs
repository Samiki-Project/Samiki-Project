using System;
using System.Timers;

namespace Samiki_Tamaguchi.Events
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
        private int intervalEat = 1000;

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
            Console.WriteLine($"Hello!~");
            Console.WriteLine($"I'm {Program.SamikiName} and we gonna eat together!");
            Console.WriteLine($"YAY! Glad you want to feed me {Program.YourName}!!");
            Console.WriteLine($"What are we gonna eat? This time it will be {Food}, right??");

            Timer EatTimer = new Timer(intervalEat)
            {
                AutoReset = true
            };
            EatTimer.Elapsed += StartEating;
            EatTimer.Start();

            Console.WriteLine("When you get tired of eating you can go out by pressing <Enter>!");
            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                EatTimer.Stop();
            }

        }
        /// <summary>
        /// Function to start the Loop of Eating with Samiki
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartEating(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine($"Eating...");
            var EatTime = DateTime.Now - lastEatCycle;
            var subtraction = EatTime.TotalSeconds;
            Program.SamikiHapiness -= Convert.ToInt32(Convert.ToSingle(subtraction));
            Console.WriteLine($"My hapiness now is in: {Program.SamikiHapiness}");


            Random random = new Random();
            int increase = random.Next(20, 30);
            Program.SamikiHunger += increase;
            Console.WriteLine($"My hunger now is in: {Program.SamikiHunger}");
        }
    }
}