using CSharpTutorial.Classes.Core.Domain.Cars;
using CSharpTutorial.Classes.Core.Domain.Humans;
using CSharpTutorial.Classes.Core.Domain.Students;
using CSharpTutorial.Classes.Core.Helpers;
using System;
using System.Drawing;

namespace CSharpTutorial.Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region [Static Methods]
            int total = MathHelper.GetSum(1, 2);
            int total2 = MathHelper.GetSum(55, 30, 15);
            double avarage = MathHelper.GetAverage(23, 43, 12);
            Console.WriteLine(total);
            Console.WriteLine(total2);
            Console.WriteLine(avarage);
            Console.WriteLine("########################");
            #endregion

            #region [Class Usage - Student]
            Student student = new Student()
            {
                FirstName = "Deniz",
                LastName = "Şimşek"
            };
            student.SetMathGrades(55, 60, 75);
            student.SetAddress("Pınar Mah.");

            Student student2 = new Student("Zeynep", "Sayan");
            student2.SetMathGrades(10, 20, 30);

            Console.WriteLine(student.GetAverageMath());
            Console.WriteLine(student2.GetAverageMath());

            Console.WriteLine(student.GetAddress());
            Console.WriteLine("########################");
            #endregion

            #region [Class Usage - Car]
            Car car = new Car("Audi", "Q7", 15d, Color.Blue, 100d);

            DateTime arrivalTime = car.GetArrivalTime(50d);
            Console.WriteLine(arrivalTime);

            DateTime time = new DateTime(2023, 1, 5, 14, 00, 00);
            DateTime arrivalTime2 = car.GetArrivalTime(time, 50d);
            Console.WriteLine(arrivalTime2);
            Console.WriteLine("####################");

            Console.WriteLine(car.Price);
            car.IncreasePrice(10);
            Console.WriteLine(car.Price);
            #endregion

            #region[Class Usage - Human]
            Human human = new Human("Deniz", "Şimşek", 19, 60d, 1.6d);
            double humanBodyMassIndex = human.GetBodyMassIndex();
            Console.WriteLine(humanBodyMassIndex);

            Human human2 = new Human("Can", "Sayan", 29, 98d, 1.8d);
            double Human2bodyMassIndex = human2.GetBodyMassIndex();
            Console.WriteLine(Human2bodyMassIndex);
            #endregion

            Console.ReadKey();
        }
    }
}
