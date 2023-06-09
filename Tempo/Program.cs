﻿using System;
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

            //Faz pausa ao programa por 0,3 segundos
            Thread.Sleep(300);

            //Pára contagem do tempo nos dois cronômetros
            crono1.Stop();
            crono2.Stop();

            //Tempo decorrido do crono1
            Console.WriteLine("Tempo decorrido no crono1 em segundos", 
            //1000 = a um segundo em milisegundos
            crono1.ElapsedMilliseconds / 1000.0);
            //Tempo decorrido do crono2
            Console.WriteLine("Tempo decorrido no crono2 em segundos", 
            //1000 = a um segundo em milisegundos
            crono2.ElapsedMilliseconds / 1000.0);
        }
    }
}
