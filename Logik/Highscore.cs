using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using static System.Console;
using System.Timers;
using System.Diagnostics;


namespace SUVRPG
{
    public class Highscore
    {
        public int Score { get; private set; }
        
        public static void BeginTimer()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            Thread.Sleep(1000);
            stopWatch.Stop();


            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
        }
        

        
        // static int seconds = 0;

        // public static void StartTimer()
        // {
        //     System.Timers.Timer aTimer = new System.Timers.Timer();
        //     aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
        //     aTimer.Interval = 1000;
        //     aTimer.Enabled = true;

        //     WriteLine("Press \'q\' to quit the sample.");
        //     while (Console.Read() != 'q') ;
        // }

        // public static void OnTimedEvent(object source, ElapsedEventArgs e)
        // {
        //     seconds++;
        // }


    }
}