using System;

namespace CSharpTutorial.Classes.Core.Helpers
{
    public class HumanHelper
    {
        public static double GetBodyMassIndex(double height, double weight)
        {
            return height / Math.Pow(weight, 2);
        }
    }
}
