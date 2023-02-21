using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial.Classes.Core.Helpers
{
    public class SpeedHelper
    {
        public static double GetArrivalHours(double distance, double speed)
        {
            return distance / speed;
        }
    }
}
