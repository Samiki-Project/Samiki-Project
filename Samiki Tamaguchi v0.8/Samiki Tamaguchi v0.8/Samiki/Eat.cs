using System;
using System.Collections.Generic;
using System.Text;

namespace Samiki_Tamaguchi_v08
{
    public partial class Samiki
    {
        public void Eat(Food food)
        {
            Console.WriteLine($"\nOhh! I'm gonna eat {food.Name_}! Yay!");
            Console.WriteLine($"I eated and regenerate {food.RecoveryValue_} points");
        }
    }
}
