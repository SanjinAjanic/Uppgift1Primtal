using System;
using System.Collections;
using System.Collections.Generic;

namespace Uppgift1Primtal
{
    class Program
    {

        static void Main(string[] args)
        {

            string input = "";
            int userInPut = 0;
            bool IsNum = false;
            bool exit = false;
            do
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("1. Enter a number");
                    Console.WriteLine("2. Print all Prime numbers");
                    Console.WriteLine("3. Exit ");
                    input = Console.ReadLine();
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
            for (int numb = 2; numb <= 100; numb++) // Listar tal från 2 till 100
            {
                bool isPrime = true;
                for (int i = 2; i <= (int)Math.Sqrt(numb); i++) // 
                {
                    if (numb % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime) // om det är ett primtal skrivs detta ut
                {
                    Console.WriteLine("Number" + numb + " is Prime number");
                }
            }
            Console.WriteLine("Press ENTER to go back to menu");
            Console.ReadLine();
        }
        /// <summary>
        /// User sets a input and method cheecks if it is a prime number or not.
        /// </summary>a
        public static void ChooseANumber()
        {

            Console.WriteLine("Enter a number");
            int numb = Convert.ToInt32(Console.ReadLine());

            bool isPrime = true;
            if (numb > 1) // if the number is > = 2 the loop will go...
            {
                for (int i = 2; i <= (int)Math.Sqrt(numb); i++)
                {
                    if (numb % i == 0)
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
                Console.WriteLine("Number"  + numb + " is Prime number");
            }
            else
            {
                Console.WriteLine("Number"  + numb + " is not Prime number");
            }
           
          
            Console.WriteLine("Press ENTER to go back to menu");
            Console.ReadLine();
        }
    }
}

/*
int[] primtalArr = { 2, 3, 5, 7, 11 };
ArrayList myNewPrim = new ArrayList(primtalArr);
myNewPrim.Add(13);
myNewPrim.Add(17);
myNewPrim.Add(19);
myNewPrim.Add(23);
myNewPrim.Add(29);
myNewPrim.Add(31);
myNewPrim.Add(37);
myNewPrim.Add(41);
myNewPrim.Add(43);
myNewPrim.Add(47);
myNewPrim.Add(53);
myNewPrim.Add(59);
myNewPrim.Add(61);
myNewPrim.Add(67);
myNewPrim.Add(71);
myNewPrim.Add(73);
myNewPrim.Add(79);
myNewPrim.Add(83);
myNewPrim.Add(89);
myNewPrim.Add(97);

for (int numb = 2; numb <= 100; numb++) // Listar tal från 2 till 100
{
bool isPrime = true;
for (int i = 2; i <= (int)Math.Sqrt(numb); i++) // 
{
if (numb % i == 0)
{
isPrime = false;
break;
}
}
if (isPrime) // om det är ett primtal skrivs detta ut
{
Console.WriteLine("Number" + numb + " is Prime number");
}
*/