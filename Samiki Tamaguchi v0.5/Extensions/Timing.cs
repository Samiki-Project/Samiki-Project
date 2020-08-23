using System;
using System.Threading;

namespace Samiki_Tamaguchi.Extensions
{
    public class MultiInterval
    {
        public static void Start(int time, bool whileCondition, params Action[] actions)
        {
            new Thread(() =>
            {
                while (whileCondition)
                {
                    Thread.Sleep(time);
                    for (int i = 0; i < actions.Length; i++)
                    {
                        Action action = actions[i];
                        action();
                    }
                }
            }).Start();
        }

        public static void Stop()
        {
            
            new NotImplementedException("Not yet implemented, under construction");
        }
    }

    public class Interval
    {
        public static void Start(Action action, int time, bool whileCondition = true)
        {
            new Thread(() =>
            {
                while (whileCondition)
                {
                    Thread.Sleep(time);
                    action();
                }
            }).Start();
        }
        public static void Stop()
        {
            throw new NotImplementedException("Not yet implemented, under construction");
        }
    }

    public class TimeOut
    {
        public static void Start(Action action, int time)
        {
            new Thread(() =>
            {
                Thread.Sleep(time);
                action();
            }).Start();
        }
        public static void Stop()
        {
            new NotImplementedException("Not yet implemented, under construction");
        }
    }
}
