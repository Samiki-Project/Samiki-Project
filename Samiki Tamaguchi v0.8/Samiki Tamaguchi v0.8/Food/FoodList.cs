using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace Samiki_Tamaguchi_v08
{
    class FoodList
    {
        public List<Food> Foodlist;

        public void Generate()
        {
            FileStream foodJson;
            foodJson = File.OpenRead("../../../Food/FoodList.json");
            byte[] exit = new byte[foodJson.Length];
            foodJson.Read(exit, 0, (int)foodJson.Length);
            Foodlist = JsonConvert.DeserializeObject<List<Food>>(Encoding.UTF8.GetString(exit));
            foodJson.Dispose();
        }

        /*/ >>> Other Way:
        /*  string jsonText = File.ReadAllText("path");
        /*  Food newFood = JsonConvert.DeserializeObject<Food>(jsonText);
        /*/
    }
}
