using System;
using System.Collections.Generic;
using System.Linq;

namespace Uppgift1Primtal
{
    class Program
    {
        public static List<int> list = new List<int>();
        static void Main(string[] args)
        {
            int userInPut = 0;
            bool IsNum = false;
            bool exit = false;
            do
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("1. Enter a number");
                    Console.WriteLine("2. Print data structure");
                    Console.WriteLine("3. Next prime number");
                    Console.WriteLine("4. Exit ");
                    string input = Console.ReadLine();
                    IsNum = int.TryParse(input, out userInPut);

                } while (IsNum == false);

                switch (userInPut)
                {
                    case 1:
                        ChooseANumber();
                        break;
                    case 2:
                        ShowPrimeNumbers();
                        break;
                    case 3:
                        NextPrimeNumberIs();
                        break;
                    case 4:
                        Console.WriteLine("Bye bye!");
                        exit = true;
                        break;
                    default:
                        break;

                }

            } while (!exit);
        }
        /// <summary>
        /// Prints all prime numbers
        /// </summary>
        public static void ShowPrimeNumbers()
        {
            if (list.Count > 0)
            {
                for (int numb = 0; numb < list.Count; numb++) // 0 - listans längd
                {
                    Console.WriteLine(list[numb] + " Is a prime number");
                }
            }
            else
            {
                Console.WriteLine("Data structure is empty");
            }
            Console.WriteLine("Press ENTER to go back to menu");
            Console.ReadLine();
        }
        /// <summary>
        /// User sets a input and method cheecks if it is a prime number or not.
        /// </summary>a
        public static void ChooseANumber()
        {
            bool IsNum = false;
            Console.WriteLine("Enter a number");
            string numberStr = Console.ReadLine();
            IsNum = int.TryParse(numberStr, out int number);
            bool isPrime = true;

            if (!IsNum)
            {
                Console.WriteLine("”wrong type of input, requires a number, please try again”.");
            }
            else
            {
                if (number > 1) // if the number is > = 2 the loop will go...
                {
                    for (int i = 2; i <= (int)Math.Sqrt(number); i++)
                    {
                        if (number % i == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                }
                else
                {
                    isPrime = false; // if the number is < 2 prime will be false
                }
                if (isPrime) //if the number is a prime number it will be printed.
                {
                    Console.WriteLine("Number " + number + " is Prime number");
                    list.Add(number);
                }
                else
                {
                    Console.WriteLine("Number " + number + " is not Prime number");
                }

            }

            Console.WriteLine("Press ENTER to go back to menu");
            Console.ReadLine();
        }
        /// <summary>
        /// Shows the next prime numbers and puts them in the data structure
        /// </summary>
        public static void NextPrimeNumberIs()
        {
            var highest = list.Count > 0 ? list.Max() : 1;

            // it will allways be a prime number between highest and highest * 2
            for (int i = highest + 1; i <= highest * 2; i++) 
            {
                bool isPrime = true;
                if (i > 1)
                {
                    for (int j = 2; j <= (int)Math.Sqrt(i); j++)
                    {
                        if (i % j == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                }
                if (isPrime)
                {
                    list.Add(i);
                    Console.WriteLine(i + " Added to the data structure");
                    Console.WriteLine("Press ENTER to go back to menu");
                    Console.ReadKey();
                    break;
                }
            }
        }
    }
}
