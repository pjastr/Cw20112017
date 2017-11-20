using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication49
{
    class Student:Osoba
    {
        private int rok;
        private int numerGrupy;
        private int numerAlbumu;

        public Student()
        {

        }

        public Student(string imie, string nazwisko, int rok, int numerGrupy, int numerAlbumu)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.rok = rok;
            this.numerAlbumu = numerAlbumu;
            this.numerGrupy = numerGrupy;
        }

        public override void WypiszInfo()
        {
            base.WypiszInfo();
            Console.WriteLine("Rok: {0}", rok);
            Console.WriteLine("Numer grupy: {0}", numerGrupy);
            Console.WriteLine("Numer albumu: {0}", numerAlbumu);
        }

        public override string ToString()
        {
            return String.Format("Imię i nazwisko: {0} {1}", imie, nazwisko) + Environment.NewLine + String.Format("Rok: {0}", rok);
        }
    }
}
