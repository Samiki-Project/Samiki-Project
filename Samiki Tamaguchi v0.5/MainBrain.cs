using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace Samiki_Tamaguchi
{
    public class MainBrain
    {
        private Timer Timer;
        private Samiko[] Samikis = new Samiko[10];

        public MainBrain()
        {
            for (int i = 0; i < Samikis.Length; i++)
            {
                Samikis[i] = new Samiko();
            }
        }

        private void LifeTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            foreach (var samiki in Samikis)
            {
                samiki.Life();
                Console.WriteLine("Executei!");
            }
        }
    }

    public class Samiko
    {
        public float Health = 100;
        public float Happiness = 100;
        private DateTime LastLifeCycle = DateTime.Now;

        public void Life()
        {
            var lifeTime = DateTime.Now - LastLifeCycle;
            var subtraction = lifeTime.TotalSeconds;
            Health -= Convert.ToSingle(subtraction);
            Happiness -= Convert.ToSingle(subtraction);

            int aaa = int.Parse(Health.ToString());
            int bbb = int.Parse(Happiness.ToString());
           
            Console.WriteLine(aaa);
            Console.WriteLine(bbb);
        }
    }
}
