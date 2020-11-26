using System;

namespace Samiki_Tamaguchi
{
    public partial class MC
    {
        /// <summary>
        /// Creates random values to the properties of Main Character: 
        /// 
        /// [<see cref="MC.Money"/> (between 100 and 1000 Ien)],
        /// </summary>
        private void GetRandomValues()
        {
            Random rnd = new Random();
            int value = rnd.Next(100, 1000);
            Money = value;
        }
    }
}