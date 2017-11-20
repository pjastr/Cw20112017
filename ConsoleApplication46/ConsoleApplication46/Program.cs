using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication46
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba student1 = new Student();
            Console.WriteLine(student1.ToString());

            Console.ReadKey();
        }
    }
}
