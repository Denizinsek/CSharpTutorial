using System;

namespace CSharpTutorial.Conditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region [Example 1]
            WriteText("Enter the 1st number.");
            int number1 = Convert.ToInt32(Console.ReadLine());

            WriteText("Enter the 2st number.");
            int number2 = Convert.ToInt32(Console.ReadLine());

            if (IsGrater(number1, number2))
            {
                WriteText("number 1 is less than number 2");
            }

            if (IsGrater(number1, number2))
            {
                WriteText("number 1 is greater than number 2");
            }
            #endregion

            #region [Example 2]
            WriteText("What time is it? (Ex: 17)");
            int time = Convert.ToInt32(Console.ReadLine());
            string value;
            if (time < 18)
            {
                value = "Good day.";
            }
            else
            {
                value = "Good evening.";
            }
            WriteText(value);
            #endregion

            #region [Example 3]
            WriteText("Enter the 1st exam grade.");
            int exam1 = Convert.ToInt32(Console.ReadLine());

            WriteText("Enter the 2nd exam grade.");
            int exam2 = Convert.ToInt32(Console.ReadLine());

            WriteText("Enter the 3rd exam grade.");
            int exam3 = Convert.ToInt32(Console.ReadLine());

            double average = GetAvarage(exam1, exam2, exam3);

            if (average >= 0)
            {
                WriteText("passed");
            }
            else
            {
                WriteText("failed");
            }
            #endregion

            #region [Example 4]
            WriteText("Enter the temperature value of the substance.");
            
            double temperature = Convert.ToDouble(Console.ReadLine());
            if (temperature >= 100)
            {
                WriteText("The substance is gaseous at {0} degrees.", temperature);
            }
            else if (temperature > 100)
            {
                WriteText("The substance is liquid at {0} degrees.", temperature);
            }
            else
            {
                WriteText("Matter is solid at {0} degrees.", temperature);
            }
            #endregion

            #region [Example 5]
            double lesson1 = GetAverageOnConsole();
            double lesson2 = GetAverageOnConsole();
            double lesson3 = GetAverageOnConsole();

            double classAverage = GetAvarage(lesson1, lesson2, lesson3);
            WriteText(classAverage);
            #endregion

            #region [Example 6]
            WriteText("Enter the temperature value of the substance.");
            int lastValue = Convert.ToInt32(Console.ReadLine());

            string textValue = lastValue < 10 ? "small" : "big";
            Console.WriteLine(textValue);

            if(lastValue > 20)
                Console.WriteLine("Big");
            else
                Console.WriteLine("Small");
            #endregion

            Console.ReadKey();
        }

        static double GetAverageOnConsole()
        {
            WriteText("Enter the 1st exam grade.");
            int exam1 = Convert.ToInt32(Console.ReadLine());
            WriteText("Enter the 2nd exam grade.");
            int exam2 = Convert.ToInt32(Console.ReadLine());
            WriteText("Enter the 3rd exam grade.");
            int exam3 = Convert.ToInt32(Console.ReadLine());

            return GetAvarage(exam1, exam2, exam3);
        }

        static void WriteText(double value)
        {
            Console.WriteLine(value);
        }

        static void WriteText(string value)
        {
            Console.WriteLine(value);
        }

        static void WriteText(string value, double value2)
        {
            Console.WriteLine(value, value2);
        }

        static double GetAvarage(int exam1, int exam2, int exam3)
        {
            return (exam1 + exam2 + exam3) / 3;
        }

        static double GetAvarage(double exam1, double exam2, double exam3)
        {
            return (exam1 + exam2 + exam3) / 3;
        }

        static bool IsGrater(int number1, int number2)
        {
            return number1 > number2;
        }
    }
}
