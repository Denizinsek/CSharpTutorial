using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial.Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = 2;
            int[] numbers = new int[length];
            numbers[0] = 12;
            numbers[1] = 24;
            
            numbers = new[] { 12, 3, 4, 23, 54, 76 };

            numbers = GetFirstValueOnArray(GetFirstValueOnArray(GetFirstValueOnArray(numbers)));

            double[] doubles = new double[] { 1d, 3d };

            string[] strings = new string[2] { "Ali", "Mehmet" };
            strings = strings.Append("Zeynep").ToArray();

            List<int> numberList = new List<int>();
            numberList.Add(15);
            numberList.Add(4);
            
            numberList.Clear();

            numberList.AddRange(numbers);

            Console.ReadKey();
        }

        static int[] GetFirstValueOnArray(int[] numbers)
        {
            int lastValue = numbers[numbers.Length - 1];
            lastValue++;
            
            numbers = numbers.Append(lastValue).ToArray();
            return numbers;
        }
    }
}
