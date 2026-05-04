using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    public class Motorcycle: Vehicle
    {
        
      
            public string FuelType { get; set; }
            public int EngineSize { get; set; }

            public Motorcycle(string brand, string model, int year,
                              string fuelType, int engineSize)
                : base(brand, model, year)
            {
                FuelType = fuelType;
                EngineSize = engineSize;
            }

            public override string GetInfo()
            {
                return base.GetInfo() +
                       $", Fuel: {FuelType}, Engine: {EngineSize}cc";
            }
        }
    }
