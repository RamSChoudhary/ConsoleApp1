using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
//using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Check());
            //DuplicateStrings();
            //UniqueStrings();
            //ReverseString();
            //ReverseWords();
            //WordCounInSentence();
            //PallindromeCheck();
            CheckMaxWordCount();
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
            if (result == input)
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

        private static string DuplicateStrings()
        {
            string input = "Ramsharan Choudhary";

            StringBuilder result = new StringBuilder();

            int parentindex = 0, childindex = 0;
            foreach (char a in input.ToLower())
            {
                foreach (char b in input.ToLower())
                {
                    if (a == b & parentindex != childindex)
                    {
                        if (!result.ToString().Contains(b.ToString()))
                            result.Append(b.ToString() + ", ");
                    }
                    childindex++;
                }
                parentindex++;
                childindex = 0;
            }
            return result.ToString();

            //StringBuilder result = new StringBuilder();
            //StringBuilder duplicateChar = new StringBuilder();

            //foreach (var item in input)
            //{
            //    if (result.ToString().IndexOf(item.ToString().ToLower()) == -1)
            //    {
            //        result.Append(item);
            //    }
            //    else
            //    {
            //        duplicateChar.Append(item);
            //    }
            //}

            //return duplicateChar.ToString();

            //
        }

        private static string UniqueStrings()
        {
            string input = "Ramsharan Choudhary";

            StringBuilder result = new StringBuilder();

            int parentindex = 0;
            foreach (char a in input.ToLower())
            {
                foreach (char b in input.ToLower())
                {
                    if (a == b)
                    {
                        parentindex++;
                    }

                }
                if (parentindex == 1)
                {
                    if (!result.ToString().Contains(a.ToString()))
                    {
                        result.Append(a.ToString() + ", ");
                    }
                }
                parentindex = 0;
            }
            return result.ToString();
        }

        private static string ReverseString()
        {
            string input = "Ramsharan Choudhary";

            StringBuilder result = new StringBuilder();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                result.Append(input[i]);
            }

            return result.ToString();
        }

        private static string ReverseWords()
        {
            string input = "Ramsharan Choudhary";

            string[] separator = input.Split(' ');
            StringBuilder result = new StringBuilder();
            for (int z = 0; z <= separator.Length - 1; z++)
            {
                for (int i = separator[z].Length - 1; i >= 0; i--)
                {
                    result.Append(separator[z][i]);
                }
                result.Append(" ");
            }

            return result.ToString();
        }

        private static int WordCounInSentence()
        {
            string input = "Ramsharan Choudhary is a genious person. He did BE, and with first Class.";

            string[] separator = input.Split(' ', ',', '.');
            ArrayList arrayList = new ArrayList();

            for (int i = 0; i <= separator.Length - 1; i++)
            {
                if (!separator[i].ToString().Equals(string.Empty))
                {
                    arrayList.Add(separator[i]);
                }
            }

            return arrayList.Count;
        }

        private static string PallindromeCheck()
        {
            string input = "radar", result = string.Empty;
            string[] split = input.Split(' ');

            for (int y = input.Length - 1; y >= 0; y--)
            {
                result += input[y].ToString();
            }
            if (result == input)
            {
                return result;

            }
            else
            {
                result = "Not Palindrome";
            }

            return result;
        }

        private static string CheckMaxWordCount()
        {
            string input = "radar is radar nothing else and radar is very good", result = string.Empty;


            string[] separator = input.Split(' ', ',', '.');
            Dictionary<string, int> arrayList = new Dictionary<string, int>();

            int parentindex = 0, childindex = 0;
            for (int i = 0; i <= separator.Length - 1; i++)
            {
                if (!arrayList.ContainsKey(separator[i]))
                    for (int z = 0; z <= separator.Length - 1; z++)
                    {

                        if (separator[i].ToString().Equals(separator[z].ToString()) && parentindex != childindex)
                        {
                            if (arrayList.ContainsKey(separator[i]))
                            {
                                int count = arrayList[separator[i]];
                                arrayList[separator[i]] = count + 1;
                            }
                        }
                        else if (!arrayList.ContainsKey(separator[i]))
                        {
                            arrayList.Add(separator[i], 1);
                        }
                        childindex++;
                    }
                parentindex++;
                childindex = 0;
            }


            return result;
        }
    }


}

