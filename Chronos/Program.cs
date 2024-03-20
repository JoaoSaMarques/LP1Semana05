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

            // Format and display the TimeSpan value.
            TimeSpan c1 = crono1.Elapsed;
            TimeSpan c2 = crono2.Elapsed;

            // Convertendo milissegundos em segundos com três casas decimais
            double elapsedSeconds1 = c1.TotalMilliseconds / 1000.0;
            double elapsedSeconds2 = c2.TotalMilliseconds / 1000.0;

            Console.WriteLine("RunTime " + elapsedSeconds1.ToString("0.000"));
            Console.WriteLine("RunTime " + elapsedSeconds2.ToString("0.000"));
        }
    }
}
