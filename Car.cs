using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    public class Car : Vehicle
    {
       
            public string FuelType { get; set; }
            public int DoorCount { get; set; }

            public Car(string brand, string model, int year,
                       string fuelType, int doorCount)
                : base(brand, model, year)
            {
                FuelType = fuelType;
                DoorCount = doorCount;
            }

            public override string GetInfo()
            {
                return base.GetInfo() +
                       $", Fuel: {FuelType}, Doors: {DoorCount}";
            }
        }
    }
