using System;
using System.Text;


namespace UpperUnion
{
    class Program
    {
        static void Main(string[] args)
        {
            //list of string
            string[] myargs = args;
            //Copy and convert to upper and an array
            string[] argsUpper = myargs.ToUpper().ToArray();
            //Sort array
            Array.Sort(myargs);
            
            //No arguments if args has no arguments
            if (args.Length == 0)
            {
                Console.WriteLine("no arguments");
                return;
            }

            //Start creating a string for sb.
            StringBuilder sb = new StringBuilder(upperString, 50);

            //Add charX to the end of sb.
            sb.Append(charX);
            
            //Add - To each sentence
            sb.AppendJoin("-");

            //Print entire sentence.
            Console.WriteLine("{0} chars: {1}", sb.Length, sb.ToString());
            
            //Print upper version.
            Console.WriteLine(upperString);
            //Print alphabetical order.
            Console.WriteLine(charX);

        }
    }
}
