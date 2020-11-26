using System;

namespace Samiki_Tamaguchi
{
    public partial class MC
    {
        public string JobName { get; set; } = "Pizza Delivery";

        public void SetJob()
        {
            Console.WriteLine("Enter the name of the service you want to try to sign in to:");
            // Under construction !!
        }

        public void Work()
        {
            int salary = default;
            {
                if (JobName.Length > 10) salary = 100;
                else salary = 50;
            }

            Money += salary;
        }
    }
}
