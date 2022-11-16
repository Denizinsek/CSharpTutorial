using System;

namespace CSharpTutorial.Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region [For]
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Test");
            }

            for (int i = 0; i < 3; i++)
                Console.WriteLine($"{i + 1} Test");

            int index0 = 3;
            for (; index0 <= 3;)
            {
                index0++;
                Console.WriteLine("Index testing..");
            }

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Please enter the {i + 1}. number:");

                if (!int.TryParse(Console.ReadLine(), out int number))
                {
                    Console.WriteLine("Please enter the valid number.");
                    Console.Read();
                    Environment.Exit(0);
                    return;
                }

                if (number == 1)
                    break;

                if (number == 2)
                    continue;

                Console.WriteLine(number);
            }

            int[] numbers = new[] { 12, 3, 4, 23, 54, 76 };

            for (int i = 0; i < numbers.Length; i++)
            {
                int number = numbers[i];
                Console.Write(number);

                if (i != numbers.Length - 1)
                    Console.Write(",");
            }

            Console.WriteLine("");
            Console.WriteLine("How many numbers do you want to sum?");

            if (!IntTryParse(Console.ReadLine(), out int sumCount))
            {
                Console.WriteLine("Please enter the valid number.");
                Console.Read();
                Environment.Exit(0);
                return;
            }

            double average = 0d;
            for (int i = 1; i <= sumCount; i++)
            {
                Console.Write($"Please enter the {i}. number:");

                if (!int.TryParse(Console.ReadLine(), out int number))
                {
                    Console.WriteLine("Please enter the valid number.");
                    Console.Read();
                    Environment.Exit(0);
                    return;
                }

                average += number;
            }
            Console.WriteLine(average / sumCount);
            #endregion

            #region [Do, While]
            Console.WriteLine("Do you want me to work? (Yes:true, No:false)");
            if (!bool.TryParse(Console.ReadLine(), out bool condition))
            {
                Console.WriteLine("Please enter the valid value.");
                Console.Read();
                Environment.Exit(0);
                return;
            }

            if (!condition)
            {
                Environment.Exit(0);
                return;
            }

            bool loopCondition = true;
            int index = 0;
            do
            {
                // Code

                if (index > 3)
                    break;

                Console.WriteLine("Test");

                index++;

                // Code
            } while (loopCondition);

            do
            {
                // Code
                Console.WriteLine("Test 2");
                index++;
                // Code
            } while (index <= 5);

            while (index <= 6)
            {
                // Code
                Console.WriteLine("Test 3");
                index++;
                // Code
            }
            #endregion

            #region [Foreach]
            int numberIndex = 0;
            int[] newNumbers = new[] { 12, 3, 4, 23, 54, 76 };
            foreach (int item in newNumbers)
            {
                Console.Write(item);

                if (numberIndex != newNumbers.Length - 1)
                    Console.Write(",");

                numberIndex++;
            }

            foreach (int item in newNumbers)
            {
                Console.WriteLine(item);
            }

            foreach (int item in newNumbers)
                Console.WriteLine(item);
            #endregion

            #region [Additionals]
            for (int i = 3; i > 0; i--)
                Console.WriteLine($"Test: {i}");

            int factorial = 1;
            for (int i = 1; i <= 5; i++)
                factorial *= i;

            Console.WriteLine(factorial);
            #endregion

            int result = GetFactorial(5);
            Console.WriteLine(result);

            Console.Read();
        }

        static int GetFactorial(int value)
        {
            if (value <= 0) return 1;

            return GetFactorial(value - 1) * value;
        }

        static bool IntTryParse(string value, out int number)
        {
            try
            {
                number = Convert.ToInt32(value);
                return true;
            }
            catch
            {
                number = 0;
                return false;
            }
        }
    }
}
