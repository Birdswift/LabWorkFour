using System;
using System.Collections;
using System.Collections.Generic;

namespace LabWorkFour
{

    class Car
    {
        public string Name { get; set; }
        public int ProductionYear { get; set; }
        public double MaxSpeed { get; set; }
    }

    class CarComparer : IComparer<Car>
    {
        string option;

        public CarComparer(string option)
        {
            this.option = option;
        }

        public int Compare(Car x, Car y)
        {

            switch (option)
            {
                case "Name":
                    return x.Name.CompareTo(y.Name);
                case "ProductionYear":
                    return x.ProductionYear.CompareTo(y.ProductionYear);
                case "MaxSpeed":
                    return x.MaxSpeed.CompareTo(y.MaxSpeed);
                default:
                    throw new ArgumentException("Invalid sort option");
            }
        }
    }


}