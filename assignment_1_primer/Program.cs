using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> numbers = new();

            while (true)
            {
                Console.WriteLine("Please enter a number");

                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Highest value " + numbers.Max());
                    Console.WriteLine("Lowest value " + numbers.Min());
                    break;
                }
                else { numbers.Add(input); }



            }

        }

    }
}


