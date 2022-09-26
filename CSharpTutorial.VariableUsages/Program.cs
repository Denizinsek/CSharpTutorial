using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial.VariableUsages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region [Byte, Integer, Long]
            // Add 15 to 30 and print them on the screen.
            int number1 = 15, number2 = 30;
            int totalNumber = number1 + number2;
            Console.WriteLine(totalNumber);

            byte byte1 = 255;
            byte byte2 = 255;
            int byteTotal = byte1 + byte2;
            Console.WriteLine(byteTotal);
            #endregion

            #region [Double, Float, Decimal, etc.]
            // Add 12.5 to 16.9 and print it on the screen.
            float floatNumber1 = 12.5f, floatNumber2 = 16.9f;
            float floatTotal = floatNumber1 + floatNumber2;
            Console.WriteLine(floatTotal);
            #endregion

            #region [Char]
            // Print only the letter z on the screen.
            char character = 'z';
            Console.WriteLine(character);
            #endregion

            #region [String]
            // Print Zeynep on the screen.
            string name = "Zeynep";
            string name2 = $"Number: {totalNumber}";

            string name3 = @"Hello World!
My name is Deniz, nice to meet you :)

Have a good day!";

            string name4 = $@"Hello World!

My niece name is {name}";

            string name5 = $"Hello World! {Environment.NewLine}My niece name is {name}";

            string name6 = "New line test.\r\nResult:12";
            Console.WriteLine(name6);
            #endregion

            #region [Object]
            object obj = "test";
            object obj1 = 1;
            object obj2 = 1.5d;
            object obj3 = 1.2f;
            object obj4 = 1.87m;
            object obj5 = 'b';
            object obj6 = "123";
            #endregion

            #region [Conversions]
            long longTotal = (long)totalNumber;
            long longTotal2 = Convert.ToInt64(totalNumber);

            double doubleTotal = (double)floatTotal;

            // int lossNumber2 = Convert.ToInt32(9223372036854775807); // OverflowException

            string charString = character.ToString();
            charString = $"{character}";
            charString = ""+character;
            charString = character + string.Empty;
            charString = Convert.ToString(character);

            string stringTotal = totalNumber.ToString() + " " + character + " " + floatNumber1;
            
            stringTotal += totalNumber;

            stringTotal = $"{totalNumber} {character} {floatNumber1}";
            Console.WriteLine(stringTotal);

            string objText = obj.ToString();
            Console.WriteLine(objText);

            // int objInteger = (int)obj; // InvalidCastException
            int objInteger = Convert.ToInt32(obj6);
            Console.WriteLine(objInteger);

            int objDoubleInteger = Convert.ToInt32(obj2);
            Console.WriteLine(objDoubleInteger);

            double objDoubleRound = Math.Round((double)obj2);
            Console.WriteLine(objDoubleRound);
            #endregion

            Console.ReadKey();
        }
    }
}
