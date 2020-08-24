using System;
using Samiki_Tamaguchi.Extensions;

namespace Samiki_Tamaguchi
{
    /// <summary>
    /// It represents a Samiki's life, her assets as money, and her feelings as happiness.
    /// <para></para>
    /// </summary>
    public partial class Samiki
    {

        /// <summary>
        /// Constructor for Samiki.
        /// <para>Defines the default values for Samiki properties ​if not defined.</para>
        /// Generates random numbers if the Boolean parameter is true
        /// </summary>
        /// <param name="random">Boolean value for generating random numbers, 
        /// when true it generates random numbers for Samiki properties</param>
        public Samiki(bool random = false)
        {
            if (random) GetRandomValues();
            else { _Hunger = 100; _Hapiness = 100; }
        }

        /// <summary>
        /// Samiki's Name
        /// <para></para>
        /// By default it is "Samiki Kobayashi", but can be customized
        /// </summary>
        public string Name { get; set; } = "Samiki Kobayashi";
        /// <summary>
        /// Samiki's Hapiness
        /// <para> By default it is 100, but can be random when creating Samiki</para>
        /// </summary>
        internal int Hapiness;
        /// <summary>
        /// Support field to call Property Happiness and define it avoiding StackOverflow Exception.
        /// </summary>
        public int _Hapiness{
            get { return Hapiness; }
            set
            {
                if (value < 0)
                    Hapiness = 0;
                else
                if (value > 100)
                    Hapiness = 100;
                else
                    Hapiness = value;
            }
        }

        /// <summary>
        /// Samiki's Hunger
        /// <para> By default it is 100, but can be random when creating Samiki</para>
        /// </summary>
        internal int Hunger;

        /// <summary>
        /// Support field to call Property Hunger and define it avoiding StackOverflow Exception.
        /// </summary>
        public int _Hunger
        {
            get { return Hunger; }
            set
            {
                if (value < 0)
                    Hunger = 0;
                else
                if (value > 100)
                    Hunger = 100;
                else
                    Hunger = value;
            }
        }
        /// <summary>
        /// Samiki's Health
        /// <para> By default it is 100, but can be random when creating Samiki</para>
        /// </summary>
        public int Health { get; set; } = 100;
        /// <summary>
        /// Samiki's Bipolarity
        /// <para> By default it is false, but can be set to true when creating Samiki</para>
        /// </summary>
        public bool Bipolar { get; set; } = false;

        /// <summary>
        /// Starts a Normal journey for Samiki
        /// <para>Creates a Interval for the functions:</para>
        /// [<see cref="GetAngry"/>] [<see cref="GetHungry"/>] and [<see cref="GetLifeless"/>]
        /// </summary>
        public void StartNormal()
        {
            if (Bipolar) throw new Exception("Error: You cannot start a Normal journey if Samiki is bipolar");
            else
            {
                Console.WriteLine("\nHapiness = {0}\nHunger = {1}\nHealth = {2}", Hapiness, Hunger, Health);
                MultiTimeOut.Start(1000, GetAngry, GetHungry, GetLifeless);
            }
        }

        /// <summary>
        /// Starts a Bipolar journey for Samiki 
        /// <para>Condition: <see cref="Samiki.Bipolar"/> = True</para>
        /// <para>Creates a TimeOut for the function:</para>
        /// <see cref="BipolarWorld"/>
        /// </summary>
        public void StartBipolar()
        {
            if (Bipolar)
            {
                Console.WriteLine("\nHapiness = {0}\nHunger = {1}\nHealth = {2}", Hapiness, Hunger, Health);
                TimeOut.Start(BipolarWorld, 500);
            }
            else throw new Exception("Error: You cannot start a Bipolar journey if Samiki is not Bipolar!");
        }

    }
}
