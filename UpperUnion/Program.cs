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
            //Print upper version.
            Console.WriteLine(upperString);
        }
    }
}
