using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int rez = 0;

            Operatii operatie = new Operatii();// creeare obiect 
            string alegere = Console.ReadLine();
            switch (alegere)
            {
                case "Suma": rez = operatie.Suma(a, b); break;
                case "Diferenta": rez = operatie.Diferenta(a, b); break;
                case "Produs": rez = operatie.Produs(a, b); break;
                case "Impartire": rez = operatie.Impartire(a, b); break;
            }

            //int rez = operatie.Suma(a, b);
            operatie.Afisare(a, b, rez);

        }
    }
}
