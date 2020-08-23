using Samiki_Tamaguchi.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Samiki_Tamaguchi
{
    public partial class Samiki
    {

        /// <summary>
        /// Function that returns the Bipolarized values ​​of Samiki properties:
        /// 
        /// [<seealso cref="Samiki.Hunger"/>] And
        /// [<see cref="Samiki.Hapiness"/>]
        /// </summary>
        private void BipolarWorld()
        {
            Random rnd = new Random();

            Console.WriteLine("\nHapiness Before: {0}", Hapiness);
            int min = default;
            int max = Hapiness;
            int value = rnd.Next(min, max);
            Hapiness -= value;
            Console.WriteLine("Random Value: {0}", value);
            Console.WriteLine("Hapiness After: {0}", Hapiness);


            Console.WriteLine("\nHunger Before: {0}", Hunger);
            min = default;
            max = Hunger;
            value = rnd.Next(min, max);
            Hunger -= value;
            Console.WriteLine("Random Value: {0}", value);
            Console.WriteLine("Hunger After: {0}", Hunger);
        }


    }
}