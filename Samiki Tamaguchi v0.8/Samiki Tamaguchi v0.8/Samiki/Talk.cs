using System;

namespace Samiki_Tamaguchi_v08
{
    public partial class Samiki
    {
        /// <summary>
        /// Makes Samiki talk an sentence passed by parameter (String)
        /// </summary>
        /// 
        /// <param name="sentence">The string which Samiki will speak</param>
        public void Talk(string sentence) => Console.WriteLine($"Samiki: {sentence}");

        public void Talk(params string[] sentence) => Console.WriteLine($"Samiki: {string.Join(' ', sentence)}");
    }
}
