using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication47
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kwadrat kw1 = new Kwadrat(6);
            //Console.WriteLine(kw1.ObliczPole());

            //Trojkat tr1 = new Trojkat(3, 4, 5);
            //Console.WriteLine(tr1.ObliczPole());

            List<Figura> figury = new List<Figura>();
            figury.Add(new Kwadrat(5));
            figury.Add(new Trojkat(3,6,4));
            figury.Add(new Kwadrat(7.2));

            figury.Add(new Trojkat(12, 5, 13));

            foreach(Figura element in figury)
            {
                Console.WriteLine(element.ObliczPole());
            }
            Console.ReadKey();
        }
    }
}
