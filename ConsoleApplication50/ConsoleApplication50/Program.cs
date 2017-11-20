using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication50
{
    class Program
    {
        static void Main(string[] args)
        {
            //Trojkat tr1 = new Trojkat(3, 4, 5);
            //Console.WriteLine(tr1.ObliczPole());

            //Kwadrat kw1 = new Kwadrat(4);
            //Console.WriteLine(kw1.ObliczPole());

            //Figura fig1 = new Figura();

            List<Figura> figury = new List<Figura>();
            figury.Add(new Kwadrat(6));
            figury.Add(new Trojkat(5, 13, 12));
            figury.Add(new Kwadrat(6.3));
            figury.Add(new Trojkat(5.6, 13.6, 12.1));
            foreach(Figura element in figury)
            {
                Console.WriteLine(element.ObliczPole());
            }
            Console.ReadKey();
        }
    }
}
