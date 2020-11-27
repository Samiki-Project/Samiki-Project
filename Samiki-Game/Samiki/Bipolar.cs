using System;

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

            //Console.WriteLine("\nHapiness Before: {0}", Hapiness);
            int min = default;
            int max = Hapiness;
            if (Hapiness < 0) { max = 0; }
            int value = rnd.Next(min, max);
            Hapiness -= value;
            //Console.WriteLine("Random Value: {0}", value);
            //Console.WriteLine("Hapiness After: {0}", Hapiness);


            //Console.WriteLine("\nHunger Before: {0}", Hunger);
            min = default;
            max = Hunger;
            if (Hunger < 0) { max = 0; }
            value = rnd.Next(min, max);
            Hunger -= value;
            //Console.WriteLine("Random Value: {0}", value);
            //Console.WriteLine("Hunger After: {0}", Hunger);

            if (Hapiness <= 0)
            {
                //Console.WriteLine("\nHealth Before: {0}", Health);
                min = default;
                max = Health;
                if (Health < 0) { max = 0; }
                value = rnd.Next(min, max);
                Health -= value;
                //Console.WriteLine("Random Value: {0}", value);
                //Console.WriteLine("Health After: {0}", Health);
            }
            //else { Console.WriteLine("I'm still Happie!"); }

        }


    }
}