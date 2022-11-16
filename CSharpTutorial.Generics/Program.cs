using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpTutorial.Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = GetNumbers();

            #region [Process 1]
            double average = numbers.Average();
            int max = numbers.Max();
            int min = numbers.Min();
            int sum = numbers.Sum();

            Console.WriteLine($"Average: {average}");
            Console.WriteLine($"Max: {max}");
            Console.WriteLine($"Min: {min}");
            Console.WriteLine($"Sum: {sum}");
            #endregion

            #region [Process 2]
            int total = 0;
            foreach (var item in numbers)
            {
                total += item;
            }
            double avr = total / 3;

            int maxValue = numbers[0];
            int minValue = numbers[0];

            foreach (var item in numbers)
            {
                if (item > maxValue)
                    maxValue = item;

                if (item < minValue)
                    minValue = item;
            }

            Console.WriteLine($"Average: {avr}");
            Console.WriteLine($"Max: {maxValue}");
            Console.WriteLine($"Min: {minValue}");
            Console.WriteLine($"Sum: {total}");
            #endregion

            List<string> names = GetNames();

            #region [Step 1]
            Console.WriteLine("Enter the name of the person you want to search.");
            string searchName = Console.ReadLine();

            if (names.Contains(searchName))
                Console.WriteLine($"{searchName} is on the list.");
            else
                Console.WriteLine($"{searchName} is not on the list.");
            #endregion

            #region [Step 2]
            Console.WriteLine("Which row person do you want to find?");

            if (!int.TryParse(Console.ReadLine(), out int row))
            {
                Console.WriteLine("Please enter the valid number.");
                Console.Read();
                Environment.Exit(0);
                return;
            }

            if (row > names.Count)
            {
                Console.WriteLine("There are not as many names as the person you specify in the list.");
                Console.Read();
                Environment.Exit(0);
                return;
            }

            string foundName = names[row - 1];
            Console.WriteLine($"Found name: {foundName}");
            #endregion

            #region [Step 3]
            Console.WriteLine("Do you want to clear list? (Yes:true | No:false)");

            if (!bool.TryParse(Console.ReadLine(), out bool isClearList))
            {
                Console.WriteLine("Please enter the valid value.");
                Console.Read();
                Environment.Exit(0);
                return;
            }

            if (isClearList)
                names.Clear();
            #endregion

            Console.ReadKey();
        }

        static List<int> GetNumbers()
        {
            List<int> numbers = new List<int>();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Please enter the {i + 1}. number!");

                if (!int.TryParse(Console.ReadLine(), out int number))
                {
                    Console.WriteLine("Please enter the valid number.");
                    Console.Read();

                    break;
                }

                numbers.Add(number);
            }

            return numbers;
        }

        static List<string> GetNames()
        {
            List<string> names = new List<string>();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Please enter the {i + 1}. name!");
                string name = Console.ReadLine();

                if (string.IsNullOrEmpty(name))
                {
                    Console.WriteLine("Please enter the name.");
                    Console.Read();
                    Environment.Exit(0);
                    break;
                }

                names.Add(name);
            }

            return names;
        }
    }
}
