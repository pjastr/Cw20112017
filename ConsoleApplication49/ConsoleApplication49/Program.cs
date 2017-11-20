using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication49
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba osoba1 = new Osoba("Jan", "Kowalski");
            Console.WriteLine(osoba1);

            Student st1 = new Student("Anna", "Nowak", 3, 4, 23456);
            Console.WriteLine(st1);

            Console.ReadKey();
        }
    }
}
