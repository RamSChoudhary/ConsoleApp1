using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Check());
        }

        private static string Check()
        {
            //string input = "zebra bat ball", result = string.Empty;
            string input = "16461", result = string.Empty;
            string[] split = input.Split(' ');
            string[] palin = new string[input.Length];

            for (int z = 0; z <= input.Length - 1; z++)
            {
                palin[z] = input[z].ToString();

            }
            for (int y = palin.Length - 1; y >= 0; y--)
            {
                result += palin[y].ToString();
            }
            if(result == input)
            {
                result = "$" + result + "$";
                return result;
            }

            result = string.Empty;
            for (int i = 0; i <= split.Length - 1; i++)
            {
                result += " ";
                for (int y = split[i].Length - 1; y >= 0; y--)
                {
                    result += split[i][y].ToString();
                }
            }

            return result;
        }
    }
}
