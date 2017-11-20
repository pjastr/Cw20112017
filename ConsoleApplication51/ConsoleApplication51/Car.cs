using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication51
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
                return this.brand.CompareTo(other.brand);
            }
            return other.year.CompareTo(this.year);
        }
        public override string ToString()
        {
            return year+" " +brand;
        }
    }
}
