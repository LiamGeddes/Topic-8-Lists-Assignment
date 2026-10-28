using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic_8_Lists_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ASSIGNMENT 1 - Reading Colors");

            List<string> colors = new List<string>();

            for (int i = 0; i <5; i++)
            {
                Console.Write("Enter a color: ");
                colors.Add(Console.ReadLine());
            }
            Console.WriteLine();

            Console.Write("Your colors are: ");

            for (int i = 0; i < colors.Count; i++)
            {
                Console.Write(colors[i]);

                if (i < colors.Count - 1)
                {
                    Console.Write(", ");
                }
            }

            Random random = new Random();
            int colorNumber = random.Next(0, colors.Count);

            Console.WriteLine();
            Console.WriteLine("Random color: " + colors[colorNumber]);

            //PROGRAMMING ASSIGNMENT 2 - RANDOM NUMBERS

            Console.WriteLine();
            Console.WriteLine("Assignment 2 - Random Numbers");

            List<int> numbers = new List<int>();

            Console.Write("How many numbers do you want? ");
            int amount = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the minimum value. ");
            int minimum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the maximum value: ");
            int maximum = Convert.ToInt32(Console.ReadLine());

            if (minimum > maximum)
            {
                int temp = maximum;
                minimum = maximum;
                maximum = temp;
            }

            for (int i = 0; i < amount; i++)
            {
                numbers.Add(random.Next(minimum, maximum + 1));
            }
            // Print the text
        }
    }
}
