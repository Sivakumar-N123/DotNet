using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    internal class Program
    {
        static void problem1()
        {
            string enteredValue;
            int count = 0;
            Console.WriteLine("Enter the String");
            enteredValue = Console.ReadLine();
            foreach( char a in enteredValue)
            {
                count = 0;
                foreach (char b in enteredValue)
                { 
                    if(a==b)
                    {
                        count++;
                    }
                }
                Console.WriteLine(a + " - " + count);
            }
            Console.ReadKey();
            Console.Clear();
            select();
        }
        static void problem2()
        {
            Console.WriteLine("1 to select for loop ");
            Console.WriteLine("2 to select foreach");
            Console.WriteLine("Enter to select ");
           int enterednumber = Convert.ToInt32(Console.ReadLine());
            switch (enterednumber)
            {
                case 1:medthod1();
                    break;
                case 2:
                    medthod2();
                    break;
            }
            void medthod1()
                {
                Console.WriteLine("Enter the string ");
                string enteredString = Console.ReadLine();
                string reversedString = "";
                foreach (char c in enteredString)
                {
                    reversedString = c + reversedString;
                }
                Console.WriteLine("Reverse String is : " + reversedString);
                Console.ReadKey();
                Console.Clear();
                select();
            }
            void medthod2()
            {
                Console.WriteLine("Enter the string ");
                string enteredString = Console.ReadLine();
                string reversedString = "";
                for (int i=0;i< enteredString.Length;i++)
                {
                    reversedString = enteredString[i] + reversedString;
                }
                Console.WriteLine("Reverse String is : " + reversedString);
                Console.ReadKey();
                Console.Clear();
                select();
            }



        }
        static void problem3()
        {
            Console.Write("Enter a String : ");
            string enteredString = Console.ReadLine();

            Console.WriteLine("All substrings for given string are : ");
 
            for (int i = 0; i < enteredString.Length; i++)
            {
                
                for (int j = 0; j < enteredString.Length - i; j++)
                {
                    Console.Write(enteredString.Substring(i, j + 1) + " ");
                }
            }

            Console.ReadKey();
            Console.Clear();
            select();
        }
        static void select()
        {
            int x;
            Console.WriteLine("select the program");
            Console.WriteLine("1 to select the program 1");
            Console.WriteLine("2 to select the program 2");
            Console.WriteLine("3 to select the program 3");
            Console.WriteLine("select 0 to exit");
            x = Convert.ToInt32(Console.ReadLine());
            switch (x)
            {
                case 1:problem1();
                    break;
                case 2:
                    problem2();
                    break;
                case 3:
                    problem3();
                    break;
                case 0:break;
                default: Console.WriteLine("enter the valid number");
                    break;
            }

        }
        static void Main(string[] args)
        {
            select();
        }
    }
}
