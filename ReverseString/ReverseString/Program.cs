using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What string would you like to be reversed?");
            string input = Console.ReadLine();
            Console.Clear();
            Console.WriteLine(StReverse(input));
            Console.Read();
            
        }

        static string StReverse(string input)
        {
            string reversed = "";
            for (int i = 0; i < input.Length; i++)
            {
                reversed = reversed.Insert(0, input[i].ToString());
            }
            return reversed;
        }
    }
}
