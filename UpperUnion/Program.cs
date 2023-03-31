using System;
using System.Linq;
using System.Text;

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

            //Convert args to uppercase and into an editable array.
            string[] argsUppercase = args.Select(arg => arg.ToUpper()).ToArray();
            
            //Sort array with uppercase letters.
            Array.Sort(argsUppercase);

            //Build new String.
            StringBuilder sb = new StringBuilder();
            //For every word.
            foreach (string word in argsUppercase)
            {
                //Word.
                sb.Append(word);
                //Put "-" between each word.
                sb.Append("-");
            }

            //Remove the last "-" character from the StringBuilder.
            sb.Remove(sb.Length - 1, 1);

            //Final converts sb to printable.
            string Final = sb.ToString();

            //Print the final sentence.
            Console.WriteLine(Final);
        }
    }
}