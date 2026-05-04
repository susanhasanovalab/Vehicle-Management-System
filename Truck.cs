using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    public class Truck : Vehicle
    {
        
            public double LoadCapacity { get; set; }

            public Truck(string brand, string model,
                         int year, double loadCapacity)
                : base(brand, model, year)
            {
                LoadCapacity = loadCapacity;
            }

            public override string GetInfo()
            {
                return base.GetInfo() +
                       $", Load Capacity: {LoadCapacity} ton";
            }
        }
    }
