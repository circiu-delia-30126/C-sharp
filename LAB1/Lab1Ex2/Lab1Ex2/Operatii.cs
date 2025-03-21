using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Ex2
{
    internal class Operatii
    {
        public int Suma(int a, int b) {
            int rez = a + b;
            return rez;
        }

        public int Diferenta(int a, int b)
        {
            int rez = a - b;
            return rez;
        }

        public int Produs(int a, int b)
        {
            int rez = a * b;
            return rez;
        }

        public int Impartire(int a, int b)
        {
            int rez = a / b;
            return rez;
        }
        public void Afisare(int a, int b, int rez)
        {
            Console.WriteLine("Parametrii sunt {0} si {1}, iar rezultatul operatiei este {2}",a,b,rez);
        }
    }
}
