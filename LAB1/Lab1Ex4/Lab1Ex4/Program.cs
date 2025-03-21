using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double inaltime = double.Parse(Console.ReadLine());
            double varsta = double.Parse(Console.ReadLine());
            char gen=char.Parse(Console.ReadLine());
            Greutate GreutateIdeala = new Greutate();

            if (gen == 'F')
            {
                GreutateIdeala.Afisare(inaltime, varsta, GreutateIdeala.IdealFemei(inaltime, varsta));
            }
            if (gen == 'B')
            {
                GreutateIdeala.Afisare(inaltime, varsta, GreutateIdeala.IdealBarbati(inaltime, varsta));
            }
            if(gen !='B' && gen != 'F')
            {
                Console.WriteLine("Introduceti F daca sunteti femeie sau B daca sunteti barbat!");
            }

        }
    }
}
