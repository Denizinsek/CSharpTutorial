namespace CSharpTutorial.Classes.Core.Helpers
{
    public class MathHelper
    {
        public static int GetSum(int number1, int number2)
        {
            return number1 + number2;
        }

        public static int GetSum(int number1, int number2, int number3)
        {
            return number1 + number2 + number3;
        }

        public static double GetAverage(int number1, int number2, int number3)
        {
            return GetSum(number1, number2, number3) / 3;
        }
    }
}
