using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int value1 = 12;
            decimal value2 = 6.2m;
            float value3 = 4.3f;

            int result1 = value1 / (int)value2;
            decimal result2 = value2 / (decimal)value3;
            float result3 = value3 / (float)value1;

            // Your code here to set result1
            Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

            // Your code here to set result2
            Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

            // Your code here to set result3
            Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
            */

            string pangram = "The quick brown fox jumps over the lazy dog";

            string[] message = pangram.Split(' ');
            string[] newMessage = new string[message.Length];

            for (int i = 0; i < message.Length; i++)
            {
                char[] tabCh = message[i].ToCharArray();
                Array.Reverse(tabCh);
                newMessage[i] = new string(tabCh);
            }

            string result = string.Join(" ", newMessage);
            Console.WriteLine($"{result}");

            Console.ReadLine();
        }
    }
}
