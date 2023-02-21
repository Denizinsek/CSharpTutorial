using CSharpTutorial.Classes.Core.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial.Classes.Core.Domain.Students
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private string Address { get; set; }
        public int MathGrade1 { get; set; }
        public int MathGrade2 { get; set; }
        public int MathGrade3 { get; set; }

        public Student()
        {

        }

        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void SetMathGrades(int mathGrade1, int mathGrade2, int mathGrade3)
        {
            MathGrade1 = mathGrade1;
            MathGrade2 = mathGrade2;
            MathGrade3 = mathGrade3;
        }

        public void SetAddress(string address)
        {
            Address = address;
        }

        public string GetAddress()
        {
            return Address;
        }

        public double GetAverageMath()
        {
            return MathHelper.GetAverage(MathGrade1, MathGrade2, MathGrade3);
        }
    }
}
