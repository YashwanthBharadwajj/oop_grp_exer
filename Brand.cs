using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_grp_exer
{
 public class Vehicle
        {
            // Variables
            private string brand;
            private string model;
            private int year;
            private bool isRunning;

            // Constructor
            public Vehicle(string brand, string model, int year)
            {
                this.brand = brand;
                this.model = model;
                this.year = year;
                this.isRunning = false; // Vehicle starts not running
            }
        }
}
