using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        //selecting the given programs
        static void Selection()
        {
            int select;

            Console.WriteLine("Enter the number between '1 to 6' to select the program");
            Console.WriteLine(" 1 to select Fibonacci");
            Console.WriteLine(" 2 to select RecursionFibonacci");
            Console.WriteLine(" 3 to select Primenumber");
            Console.WriteLine(" 4 to select Palindrome");
            Console.WriteLine(" 5 to select SumOfDigits");
            Console.WriteLine(" 6 to select BinaryToDecimal");
            Console.WriteLine(" 7 to exit");
            // getting input to select
            select = Convert.ToInt32(Console.ReadLine());
            switch (select)
            {
                case 1:
                    Fibonacci();
                    break;
                case 2:
                    RecursionFibonacci();
                    break;
                case 3:
                    Primenumber();
                    break;
                case 4:
                    Palindrome();
                    break;
                case 5:
                    SumOfDigits();
                    break;
                case 6:
                    BinaryToDecimal();
                    break;
                case 7: break;
                default:
                    Console.WriteLine("Enter number between 1 to 6");
                    break;

            }
        }
        static void Fibonacci()
        {
            //getting length for printing
            int lengthToPrint, number1 = 0, number2 = 1, number3;
            Console.WriteLine("Enter the length to print Fibonacci");
            lengthToPrint = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number1);
            Console.WriteLine(number2);
            for (int i = 2; i < lengthToPrint; i++)
            {
                number3 = number1 + number2;
                number1 = number2;
                number2 = number3;
                Console.WriteLine(number3);
            }

            Console.ReadKey();
            Console.Clear();
            Selection();


        }
        static void RecursionFibonacci()
        {
            int lengthToPrint, count = 2, number1 = 0, number2 = 1, number3;
            Console.WriteLine("Enter the length to print Fibonacci");
            lengthToPrint = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number1);
            Console.WriteLine(number2);

            // calling the recursion function
            recursion(count);

            void recursion(int x)
            {

                if (count < lengthToPrint)
                {
                    number3 = number1 + number2;
                    number1 = number2;
                    number2 = number3;
                    Console.WriteLine(number3);
                    count++;
                    recursion(count);
                }
            }
            Console.ReadKey();
            Console.Clear();
            Selection();
        }
        static void Primenumber()
        {
            int isPrimeNumber, temp = 0;
            Console.WriteLine("enter the number to check prime number");
            isPrimeNumber = Convert.ToInt32(Console.ReadLine());

            //checking the entered number is zero or not

            if (isPrimeNumber != 0)
            {
                for (int i = 2; i < isPrimeNumber; i++)
                {
                    if (isPrimeNumber % i == 0)
                    {
                        temp = 1;
                        break;
                    }
                }
                // checking the entered number is prime number or not
                if (temp == 0)
                {
                    Console.WriteLine("Yes, " + isPrimeNumber + " is a prime number");
                }
                else
                {
                    Console.WriteLine("No, " + isPrimeNumber + " is not a prime number");

                }
            }
            else
            {
                Console.WriteLine("Enter the other number not zero");
            }
            Console.ReadKey();
            Console.Clear();
            Selection();
        }
        static void Palindrome()
        {
            int ispalindrome, reminder = 0, temp;
            Console.WriteLine("Enter the number to check palindrome");
            ispalindrome = Convert.ToInt32(Console.ReadLine());
            temp = ispalindrome;
            while (temp != 0)
            {
                reminder = (reminder * 10) + temp % 10;
                Console.WriteLine(reminder);

                temp /= 10;
            }
            if (ispalindrome == reminder)
            {
                Console.WriteLine("the entered number " + ispalindrome + " is a palindrome");
            }
            else
            {
                Console.WriteLine("the entered number " + ispalindrome + " is not a palindrome");
            }
            Console.ReadKey();
            Console.Clear();
            Selection();
        }
        static void BinaryToDecimal()
        {
            int numberToChange, binaryNumber=0, temp;
            string result = "";
            Console.WriteLine("Enter the number to convert into binary");
            numberToChange = Convert.ToInt32(Console.ReadLine());
            temp = numberToChange;
            if (temp != 0)
            {
                while (temp != 0)
                {
                    binaryNumber =temp % 2;
                    result = Convert.ToString(binaryNumber) + result;

                    temp /= 2;
                }

            }
            Console.WriteLine("the binary value of the number " + numberToChange + " is " + result);
            Console.ReadKey();
            Console.Clear();
            Selection();
        }
        static void SumOfDigits()
        {
            int SumingDigits, sum = 0;
            Console.WriteLine("Enter the number to sum the digits");
            SumingDigits = Convert.ToInt32(Console.ReadLine());

            while (SumingDigits != 0)
            {
                sum += SumingDigits % 10;
                SumingDigits /= 10;
            }

            Console.WriteLine(sum);
            Console.ReadKey();
            Console.Clear(); ;
            Selection();
        }
        static void Main(string[] args)
        {
            Selection();
        }

    }
}
