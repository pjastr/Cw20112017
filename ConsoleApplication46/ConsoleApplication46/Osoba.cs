using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication46
{
    class Osoba
    {
        protected string imie;
        protected string nazwisko;

        public Osoba()
        {

        }

        public Osoba(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
        }

        public virtual void WypiszInfo()
        {
            Console.WriteLine("Imię i nazwisko: {0} {1}", imie, nazwisko);
        }

        public override string ToString()
        {
            return String.Format("Imię i nazwisko: {0} {1}", imie, nazwisko);
        }
    }
}
