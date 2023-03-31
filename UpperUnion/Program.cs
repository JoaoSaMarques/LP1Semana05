using System;
using System.Linq;

namespace UpperUnion
{
    class Program
    {
        static void Main(string[] args)
        {
            //If the user didn't write anything in args.
            if (args.Length == 0)
            {
                //Print no arguments.
                Console.WriteLine("no arguments");
                return;
            }

            //Inform the user it will be converted to uppercase.
            Console.WriteLine("The following is your sentence in uppercase: ");

            //Convert args to uppercase and into an editable array.
            string[] argsUppercase = args.Select(arg => arg.ToUpper()).ToArray();

            //Make a copy of argsUppercase
            string[] sorter = (argsUppercase);
            
            //Sort array with uppercase letters.
            Array.Sort(argsUppercase);

            //Sort Array in alphabetical order.
            Array.Sort(sorter);

            //Join every string with "-"
            string Final = string.Join("-", argsUppercase);

            //Print the final sentence.
            Console.WriteLine(Final);
            
            //Print sorted sentence in alphabetical order
            Console.WriteLine(sorter);
        }
    }
}