using System;

namespace RandomDice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Quantidade de dados lançados.
            Console.WriteLine("Input the number of the dice: ");
            //Converter a string em inteiro.
            int n = int.Parse(Console.ReadLine());

            //Precisamos disto quando tivermos que sumar o valor dado.
            int sum = 0;

            //Temos que criar um valor entre 1 e 6 para cada dado lançado.
            Random value = new Random();

            //Vai deixar-nos fazer um limitador entre 1 e 6.
            for (int i = 0; i < n; i++)
            {
                //Random value for each dice.
                int dice = value.Next(1, 6);
                //0 + Dice values
                sum = sum + dice; 
            }
            //Sum of all dice
            Console.WriteLine("The sum of the dice are: " + sum);
        }
    }
}
