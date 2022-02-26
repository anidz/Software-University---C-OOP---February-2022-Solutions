using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Vehicle
    {
        private double defaultFuelConsumption;

        public Vehicle(int horsePower, double fuel)
        {
            HorsePower = horsePower;
            Fuel = fuel;
            defaultFuelConsumption = 1.25;
        }

        public virtual double FuelConsumption => defaultFuelConsumption;
        public double Fuel { get; protected set; }
        public int HorsePower { get; protected set; }

        public virtual void Drive(double kilometers)
        {
            Fuel -= kilometers * FuelConsumption;
        }
    }
}

