using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWorkFour
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] cars = new Car[]
            {
            new Car { Name = "Car1", ProductionYear = 2020, MaxSpeed = 200 },
            new Car { Name = "Car2", ProductionYear = 2018, MaxSpeed = 220 },
            new Car { Name = "Car3", ProductionYear = 2020, MaxSpeed = 180 },
            new Car { Name = "Car4", ProductionYear = 2019, MaxSpeed = 210 }
            };
            Console.WriteLine("Sorting by speed");
            Array.Sort(cars, new CarComparer("MaxSpeed"));
            foreach (Car car in cars)
            {
                Console.WriteLine(car.MaxSpeed);
            }
            CarCatalog catalog = new CarCatalog(cars);

            Console.WriteLine("Forward way");
            foreach (var car in catalog.Forward())
            {
                Console.WriteLine($"{car.Name} ({car.ProductionYear}), MaxSpeed: {car.MaxSpeed}");
            }
            Console.WriteLine("Reverse way");
            foreach (var car in catalog.Reverse())
            {
                Console.WriteLine($"{car.Name} ({car.ProductionYear}), MaxSpeed: {car.MaxSpeed}");
            }

            Console.WriteLine("\nBy year 2020");
            foreach (var car in catalog.FilterByYear(2020))
            {
                Console.WriteLine($"{car.Name} ({car.ProductionYear}), MaxSpeed: {car.MaxSpeed}");
            }

            Console.WriteLine("\nBy speed 220");
            foreach (var car in catalog.FilterByMaxSpeed(220))
            {
                Console.WriteLine($"{car.Name} ({car.ProductionYear}), MaxSpeed: {car.MaxSpeed}");
            }

            

            MyMatrix matrix1 = new MyMatrix(5, 6);
            MyMatrix matrix2 = new MyMatrix(5, 6);
            MyMatrix matrix3 = new MyMatrix(5, 6);
            MyMatrix matrix4 = new MyMatrix(6, 7);
            MyMatrix matrix0;
            matrix0 = matrix2 + matrix1;
            Console.WriteLine($"Sum");
            matrix3.PrintMyMatrix();
            matrix0 = matrix3 * matrix4;
            Console.WriteLine($"Mult");
            matrix0.PrintMyMatrix();
            matrix0 = matrix3 / 2;
            matrix0.PrintMyMatrix();
        }
    }
}
