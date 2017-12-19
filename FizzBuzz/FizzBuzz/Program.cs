using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int number;
            bool done = false;
            string tryagain;
            while (!done)
            {
                Console.Clear();
                Console.WriteLine("Welcome to FizzBuzz! Insert an integer to play!");
                input = Console.ReadLine();
                if (Int32.TryParse(input, out number))
                {
                    if (number % 3 == 0)
                    {
                        if (number % 5 == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("You won a FizzBizz!");
                            done = true;
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("You won a Fizz!");
                            done = true;
                            Console.ReadLine();
                        }
                    }
                    else if (number % 5 == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("You won a Bizz");
                        done = true;
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine(number + " is not very FizzBizzy! Try again!");
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Sorry, " + input + " isn't an integer! Try again!");
                    Console.ReadLine();
                }
                if (done)
                {
                    while (done)
                    {
                        Console.Clear();
                        Console.WriteLine("Play again? (y/n)");
                        input = Console.ReadLine().ToLower();
                        if (input == "y")
                        {
                            done = false;
                        }
                        else if (input == "n")
                        {
                            done = true;
                        }
                        else
                        {
                            Console.Clear(); 
                            Console.WriteLine("What was that? (y/n)");
                            Console.ReadLine();
                        }
                    }
                }
            } // End While Loop
        }
    }
}
