using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication48
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            cars.Add(new Car(2010, "Ford"));
            cars.Add(new Car(2016, "Fiat"));
            cars.Add(new Car(2012, "Skoda"));
            cars.Add(new Car(2010, "BMW"));
            cars.Sort();
        }
    }
}
