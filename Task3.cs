using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;


namespace LabWorkFour
{
    class CarCatalog : IEnumerator<Car>
    {
        private Car[] cars;
        private int currentIndex = -1;

        public CarCatalog(Car[] cars)
        {
            this.cars = cars;
        }

        public Car Current => cars[currentIndex];

        object IEnumerator.Current => Current;

        public bool MoveNext()
        {
            currentIndex++;
            return currentIndex < cars.Length;
        }

        public void Reset()
        {
            currentIndex = -1;
        }

        public void Dispose()
        {
        }

        public IEnumerable<Car> Forward()
        {
            Reset();
            while (MoveNext())
            {
                yield return Current; 
            }
        }

        public IEnumerable<Car> Reverse()
        {
            Reset();
            currentIndex = cars.Length;
            while (currentIndex >0)
            {
                currentIndex--;
                yield return Current;
            }
        }

        public IEnumerable<Car> FilterByYear(int year)
        {
            Reset();
            while (MoveNext())
            {
                if (Current.ProductionYear == year)
                {
                    yield return Current;
                }
            }
        }

        public IEnumerable<Car> FilterByMaxSpeed(int maxSpeed)
        {
            Reset();
            while (MoveNext())
            {
                if (Current.MaxSpeed == maxSpeed)
                {
                    yield return Current;
                }
            }
        }
    }

   

}
