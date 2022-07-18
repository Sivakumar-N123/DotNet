using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstValue;
            Console.WriteLine("Enter the first value");
            firstValue = Console.ReadLine();
            string secondValue;
            Console.WriteLine("Enter the second value");
            secondValue = Console.ReadLine();
            char[] temp = firstValue.ToLower().ToCharArray();
            char[] temp1 = secondValue.ToLower().ToCharArray();
            Array.Sort(temp);
            Array.Sort(temp1);
            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] != temp1[i])
                {
                    Console.WriteLine("Both string are not anagram string");
                }
            }
            Console.WriteLine("Both string are  anagram string");
            Console.ReadLine();
        }
    }
}
