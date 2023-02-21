﻿using CSharpTutorial.Classes.Core.Helpers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial.Classes.Core.Domain.Cars
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public double Speed { get; set; }
        public Color Color { get; set; }
        public double Price { get; set; }

        public Car()
        {

        }

        public Car(string brand, string model, double speed, Color color, double price)
        {
            Brand = brand;
            Model = model;
            Speed = speed;
            Color = color;
            Price = price;
        }

        public void IncreasePrice(double percent)
        {
            Price += Price * (percent / 100);
        }

        public double GetArrivalHours(double distance)
        {
            return SpeedHelper.GetArrivalHours(distance, Speed);
        }

        public DateTime GetArrivalTime(double distance)
        {
            double hours = GetArrivalHours(distance);

            return DateTime.Now.AddHours(hours);
        }

        public DateTime GetArrivalTime(DateTime time, double distance)
        {
            double hours = GetArrivalHours(distance);

            return time.AddHours(hours);
        }
    }
}
