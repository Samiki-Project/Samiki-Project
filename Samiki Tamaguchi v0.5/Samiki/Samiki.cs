using System;
using System.Timers;
using Samiki_Tamaguchi.Extensions;

namespace Samiki_Tamaguchi
{
    public partial class Samiki
    {
        public string Name = "Samiki Kobayashi";
        public int Hapiness { get; set; } = 100;
        public int Hunger { get; set; } = 100;
        public int Health { get; set; } = 100;
        public bool Bipolar { get; set; } = false;

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
        }

        /// <summary>
        /// Starts a Normal journey for Samiki
        /// <para>Creates a Interval for the functions:</para>
        /// [<see cref="GetAngry"/>] <see cref="GetHungry"/> and <see cref="GetLifeless"/>
        /// </summary>
        public void StartNormal()
        {
            if (Bipolar) throw new Exception("Error: You cannot start a Normal journey if Samiki is bipolar");
            else
            {
                Console.WriteLine("Hapiness = {0}\nHunger = {1}\nHealth = {2}", Hapiness, Hunger, Health);
                MultiInterval.Start(5000, true, GetAngry, GetHungry, GetLifeless);
            }
        }

        /// <summary>
        /// Starts a Bipolar journey for Samiki 
        /// <para>Condition: <see cref="Samiki.Bipolar"/> = True</para>
        /// <para>Creates a Interval for the function:</para>
        /// <see cref="BipolarWorld"/>
        /// </summary>
        public void StartBipolar()
        {
            if (Bipolar)
            {
                Console.WriteLine("Hapiness = {0}\nHunger = {1}\nHealth = {2}", Hapiness, Hunger, Health);
                Interval.Start(BipolarWorld, 3000);
            }
            else throw new Exception("Error: You cannot start a Bipolar journey if Samiki is not Bipolar!");
        }

    }
}
