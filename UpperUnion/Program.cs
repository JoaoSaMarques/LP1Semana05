using System;


namespace UpperUnion
{
    class Program
    {
        static void Main(string[] args)
        {
            //User order.
            Console.WriteLine("Write a sentence");
            //Read string of user.
            string string1 = (Console.ReadLine());

            //Convert string to uppercase.
            string upperString = string1.ToUpper();

            //copy upperstring into a separate string.
            string x = upperString;

            //convert string x to char array
            char[] charX = x.ToCharArray();

            //Sort array alphabetically
            Array.Sort(charX);

            //Print upper version.
            Console.WriteLine(upperString);
            //Print alphabetical order.
            Console.WriteLine(charX);

        }
    }
}
