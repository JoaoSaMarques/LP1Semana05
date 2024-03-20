using System;
using System.Diagnostics;
using System.Threading;

namespace Chronos
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch crono1 = new Stopwatch();
            Stopwatch crono2 = new Stopwatch();

            crono1.Start();
            Thread.Sleep(600);

            crono2.Start();
            Thread.Sleep(200);

            crono1.Stop();
            crono2.Stop();

            TimeSpan c1 = crono1.Elapsed;
            TimeSpan c2 = crono2.Elapsed;

            // Format and display the TimeSpan value.
            string Elapsed1 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                c1.Hours, c1.Minutes, c1.Seconds, c1.Milliseconds / 10);
            Console.WriteLine("RunTime " + Elapsed1);

            string Elapsed2 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                c2.Hours, c2.Minutes, c2.Seconds, c2.Milliseconds / 10);
            Console.WriteLine("RunTime " + Elapsed2);
        }
    }
}
