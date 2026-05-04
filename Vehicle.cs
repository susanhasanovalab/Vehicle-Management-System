using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    public class Vehicle
    {
      
            private string brand;
            private string model;
            private int year;

            public string Brand
            {
                get { return brand; }
                set { brand = value; }
            }

            public string Model
            {
                get { return model; }
                set { model = value; }
            }

            public int Year
            {
                get { return year; }
                set
                {
                    if (value >= 1900)
                    {
                        year = value;
                    }
                    else
                    {
                        Console.WriteLine("Year 1900-dən kiçik ola bilməz!");
                    }
                }
            }

            public Vehicle(string brand, string model, int year)
            {
                Brand = brand;
                Model = model;
                Year = year;
            }

            public virtual string GetInfo()
            {
                return $"Brand: {Brand}, Model: {Model}, Year: {Year}";
            }
        }
    }

