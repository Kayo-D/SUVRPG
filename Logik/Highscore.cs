using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using static System.Console;
using System.Timers;
using System.Diagnostics;
using Dapper;
using MySqlConnector;


namespace SUVRPG
{
    public static class Highscore
    {
        public static void TriggerHoF()
        {
            
        }
        
        
        // Stopwatch-kod för att sedan eventuellt kunna impletementera tidtagning. 
        
        // public int Score { get; private set; }
        
        // public static void BeginTimer()
        // {
        //     Stopwatch stopWatch = new Stopwatch();
        //     stopWatch.Start();
        //     Thread.Sleep(1000);
        //     stopWatch.Stop();


        //     TimeSpan ts = stopWatch.Elapsed;
        //     string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
        //         ts.Hours, ts.Minutes, ts.Seconds,
        //         ts.Milliseconds / 10);
        //     Console.WriteLine("RunTime " + elapsedTime);
        // }

    }
}