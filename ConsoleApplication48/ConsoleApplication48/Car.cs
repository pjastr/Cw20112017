using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication48
{
    class Car:IComparable<Car>
    {
        private int year;
        private string brand;

        public Car(int year, string brand)
        {
            this.year = year;
            this.brand = brand;
        }

        public int CompareTo(Car other)
        {
            if (this.year == other.year)
            {
                return other.brand.CompareTo(this.brand);
            }
            return this.year.CompareTo(other.year);
        }
    }
}
