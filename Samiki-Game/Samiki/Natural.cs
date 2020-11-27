using System;

namespace Samiki_Tamaguchi
{
    public partial class Samiki
    {
        /// <summary>
        /// Function that randomizes a value and uses it to decrease Samiki's Hunger property
        /// </summary>
        private void GetHungry()
        {
          //  Console.WriteLine("\nHunger Before: {0}", Hunger);
            Random rnd = new Random();

            int min = default;
            int max = Hunger;
            int reducerIndex = Hunger / 2;
            int value = default;
            try
            {
                if (Hunger > 0) min = Hunger / reducerIndex;
                if (Hunger > 0 && reducerIndex >= min) max = rnd.Next(min, reducerIndex);
                if (Hunger < 0) { max = 0; }
                value = rnd.Next(min, max);
            }
            catch (DivideByZeroException) { value = 1; }

            Hunger -= value;

            //Console.WriteLine("Random Value: {0}", value);
            //Console.WriteLine("Hunger After: {0}", Hunger);
        }

        /// <summary>
        /// Function that randomizes a value and uses it to decrease Samiki's Hapiness property
        /// </summary>
        private void GetAngry()
        {
            //Console.WriteLine("\nHapiness Before: {0}", Hapiness);
            Random rnd = new Random();

            int min = default;
            int max = Hapiness;
            int reducerIndex = Hapiness / 2;
            int value;
            try
            {
                if (Hapiness > 0) min = Hapiness / reducerIndex;
                if (Hapiness > 0 && reducerIndex >= min) max = rnd.Next(min, reducerIndex);
                if (Hapiness < 0) { max = 0; }
                value = rnd.Next(min, max);
            }
            catch (DivideByZeroException) { value = 1; }

            Hapiness -= value;

            //Console.WriteLine("Random Value: {0}", value);
            //Console.WriteLine("Hapiness After: {0}", Hapiness);
        }

        /// <summary>
        /// Function that randomizes a value and uses it to decrease Samiki's Health property
        /// <para>Condition: Hapiness = 0</para>
        /// </summary>
        private void GetLifeless()
        {
            Random rnd = new Random();
            if (Hapiness <= 0)
            {

                //Console.WriteLine("\nHealth Before: {0}", Health);
                int min = default;
                int max = Health;
                int reducerIndex = Health / 4;
                int value = default;
                
                try
                {
                    if (Health > 0) min = Health / reducerIndex;
                    if (Health > 0 && reducerIndex >= min) max = rnd.Next(min, reducerIndex);
                    if (Health < 0) { max = 0; }
                    value = rnd.Next(min, max);
                }
                catch (DivideByZeroException) { value = 1; }

                Health -= value;

                //Console.WriteLine("Random Value: {0}", value);
                //Console.WriteLine("Health After: {0}", Health);
            }
            //else Console.WriteLine("I'm Still happie >.<");
        }


    }
}
