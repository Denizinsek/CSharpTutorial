using System;

namespace CSharpTutorial.Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteText("What ", "Why ", "How ", "When", "Where", "Who", "wich");

            WriteText("a", "b", "c", "d", "e", "f", "x");

            int total = Sum(12, 12, 3, 2);
            WriteText(total);

            int total2 = Sum(12, 12, 3);
            WriteText(total2);

            int total3 = Sum(12, 12);
            WriteText(total3);

            string value = CombineText(12, 12);
            WriteText(value);

            int result = Sum(24, 24, 5, 4);
            WriteText(result);

            float result1 = Multiplication(8.1f, 10.2f, 2.3f);
            WriteText(result1);

            SumAndWrite(13, 14);

            WriteText(Sum(4, 34));

            int s1 = 4 + 34;
            int s2 = 1 + 3;
            int sTotal = s1 + s2;
            Console.WriteLine(sTotal);

            int sum1 = Sum(4, 34);
            int sum2 = Sum(1, 3);
            int sumTotal = Sum(sum1, sum2);
            WriteText(sumTotal);

            WriteText(Sum(Sum(4, 34), Sum(1, 3)));

            WriteText(Sum(Sum(4, 34), Subtraction(13, 3)));
            // Step 1: WriteText(Sum(38, 10));
            // Step 1: WriteText(48);

            WriteText(Sum(Sum(4, 34), Sum(13, 3)));
            // Step 1: WriteText(Sum(38, 16));
            // Step 1: WriteText(54);

            Console.ReadKey();
        }

        static void WriteText(string value, string value2, string value3, string value4, string value5, string value6, string value7)
        {
            WriteText(value);
            WriteText(value2);
            WriteText(value3);
            WriteText(value4);
            WriteText(value5);
            WriteText(value6);
            WriteText(value7);
        }

        static int Sum(int number1, int number2, int number3, int number4)
        {
            int total1 = Sum(number1, number2);
            int total2 = Sum(number3, number4);

            return total1 + total2;
        }

        static int Sum(int number1, int number2, int number3)
        {
            return number1 + number2 + number3;
        }

        static int Sum(int number1, int number2)
        {
            return number1 + number2;
        }

        static int Subtraction(int number1, int number2)
        {
            return number1 - number2;
        }

        static float Multiplication(float number1, float number2, float number3)
        {
            return number1 * number2 * number3;

        }

        static string CombineText(int number1, int number2)
        {
            return $"Number 1: {number1} | Number 2: {number2}";
        }

        static void SumAndWrite(int number1, int number2)
        {
            int total = number1 + number2;

            WriteText(total);
        }

        static void WriteText(string value)
        {
            Console.WriteLine(value);
        }

        static void WriteText(int value)
        {
            Console.WriteLine(value);
        }

        static void WriteText(float value)
        {
            Console.WriteLine(value);
        }
    }
}
