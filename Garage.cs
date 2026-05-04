using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    public class Garage
    {
     
            private List<Vehicle> vehicles = new List<Vehicle>();

            public void AddVehicle(Vehicle v)
            {
                vehicles.Add(v);
            }

            public void ShowAllVehicles()
            {
                foreach (Vehicle v in vehicles)
                {
                    Console.WriteLine(v.GetInfo());
                }
            }
        }
    }
