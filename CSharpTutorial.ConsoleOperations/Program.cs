using System;

namespace CSharpTutorial.ConsoleOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region [Write single text]
            // Printing Hello World on Screen with C#
            Console.WriteLine("Hello World");
            Console.ReadKey();
            #endregion

            #region [Write text with combined]
            // Printing on the screen by taking the name and surname information into string variables with C#
            string name, surname;
            Console.Write("Name: ");
            name = Console.ReadLine();
            Console.Write("Surname: ");
            surname = Console.ReadLine();
            Console.WriteLine("Hello {0} {1}", name, surname);
            Console.ReadKey();
            #endregion

            #region [Write sum some numbers]
            // Simple Console program that asks the user for 2 numbers and finds the sum of these numbers
            double number1, number2, result;
            Console.Write("1.number :");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2.number :");
            number2 = Convert.ToInt32(Console.ReadLine());
            result = number1 + number2;
            Console.WriteLine("{0} ve {1} sum of the number : {2}", number1, number2, result);
            Console.ReadKey();
            #endregion

            #region [Math functions with operators]
            // Simple C# Console application that prompts the user for 2 numbers and displays the sum, difference, multiplication and division of these numbers on the screen
            double numberFirst, numberSecond, total, difference, multiplication, division;
            Console.Write("Please enter to first number:");
            numberFirst = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter to second number:");
            numberSecond = Convert.ToInt32(Console.ReadLine());
            total = numberFirst + numberSecond;
            difference = numberFirst - numberSecond;
            multiplication = numberFirst * numberSecond;
            division = numberFirst / numberSecond;
            Console.WriteLine("{0} ve {1} sum of the number:{2}", numberFirst, numberSecond, total);
            Console.WriteLine("{0} ve {1} the difference in numbers:{2}", numberFirst, numberSecond, difference);
            Console.WriteLine("{0} ve {1} multiplication of numbers:{2}", numberFirst, numberSecond, multiplication);
            Console.WriteLine("{0} ve {1} division of numbers:{2}", numberFirst, numberSecond, division);
            Console.ReadKey();
            #endregion
        }
    }
}
