using CSharpTutorial.Classes.Core.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial.Classes.Core.Domain.Humans
{
    public class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }

        public Human()
        {

        }

        public Human(string firstName, string lastName, int age, double height, double weight)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Height = height;
            Weight = weight;
        }

        public double GetBodyMassIndex()
        {
            return HumanHelper.GetBodyMassIndex(Height, Weight);
        }
    }
}
