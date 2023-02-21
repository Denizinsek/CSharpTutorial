using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
