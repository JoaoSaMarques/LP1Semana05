using System;
using System.Diagnostics;
using System.Threading;

namespace Tempo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declara ambos os cronos
            Stopwatch crono1 = new Stopwatch();
            Stopwatch crono2 = new Stopwatch();

            //Inicia contagem 1
            crono1.Start();

            //Faz pausa ao programa por 0,5 segundos
            Thread.Sleep(500);

            //Inicia contagem 2 
            crono2.Start();
        }
    }
}
