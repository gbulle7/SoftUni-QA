using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using System.Xml;
using System.Xml.Linq;

namespace C__Fund___Unit_Tests_VS_TopLevelDisabled
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            string output = "";
            if (input == "int")
            {
                int intOutput = CompareBigger(int.Parse(first), int.Parse(second));
                output = intOutput.ToString();
            }
            else if (input == "char")
            {
                char charOutput = CompareBigger(char.Parse(first), char.Parse(second));
                output = charOutput.ToString();
            }
            else if (input == "string")
            {
                output = CompareBigger(first, second);
            }
            Console.WriteLine(output);
        }

        static int CompareBigger(int num1, int num2)
        {
            int bigger = Math.Max(num1, num2);
            return bigger;
        }

        static char CompareBigger(char char1, char char2)
        {
            char biggerChar = (char) Math.Max(char1, char2);
            return biggerChar;
        }

        static string CompareBigger(string string1, string string2)
        {
            // Using Compare, can also make it with CompareTo
            //string biggerStr = string1;
            //int bigger = string.Compare(string1, string2);
            //if (bigger < 0) { biggerStr = string2; }
            //return biggerStr;

            // Without built-in methods
            int shortLength = Math.Min(string1.Length, string2.Length);
            // Check if one string has a different (bigger) following character
            for (int i = 0; i < shortLength; i++)
            {
                if (string1[i] > string2[i])
                {
                    return string1;
                }
                else if (string1[i] < string2[i])
                {
                    return string2;
                }
            }
            // If strings are same characters but different length
            return string1.Length > string2.Length ? string1 : string2;     
        }
    }
}
