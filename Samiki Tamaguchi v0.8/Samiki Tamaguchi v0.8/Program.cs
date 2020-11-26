using System;

namespace Samiki_Tamaguchi_v08
{
    class Program
    {
        static void Main()
        {
            Samiki samiki = new Samiki();
            FoodList foodList = new FoodList();
            foodList.Generate();
            foreach (var item in foodList.Foodlist)
            {
                samiki.Eat(item);
            }
        }
    }
}