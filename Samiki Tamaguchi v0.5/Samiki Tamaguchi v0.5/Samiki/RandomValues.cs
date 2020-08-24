using System;

namespace Samiki_Tamaguchi
{
    public partial class Samiki
    {
        /// <summary>
        /// Creates random values to the properties of Samiki: 
        /// 
        /// [<see cref="Samiki.Hunger"/> (between 40 and 100)],
        /// [<see cref="Samiki.Hapiness"/> (between 40 and 100)] and
        /// [<see cref="Samiki.Health"/> (between 90 and 100)] 
        /// </summary>
        private void GetRandomValues()
        {
            Random rnd = new Random();
            int value = rnd.Next(40, 100);
            _Hapiness = value;
            value = rnd.Next(40, 100);
            _Hunger = value;
            value = rnd.Next(90, 100);
            Health = value;
        }
    }
}