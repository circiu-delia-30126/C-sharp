using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Ex4
{
    internal class Greutate
    {
        public double IdealFemei(double inaltime, double varsta)
        {
            double GreutateIdeala = (inaltime - 100 - ((inaltime - 150) / 4)) + ((varsta - 20) / 4);
            return GreutateIdeala;

        }

        public double IdealBarbati(double inaltime, double varsta)
        {
            double GreutateIdeala = (inaltime - 100 - ((inaltime - 150) / 2.5)) + ((varsta - 20) / 6);
            return GreutateIdeala;
        }
        public void Afisare(double inaltime, double varsta, double greutate)
        {
            Console.WriteLine("Greutatea ideala pentru o inaltime de {0} cm si varsta de {1} ani este {2} kg", inaltime, varsta, greutate);

        }
    }
}

        


    
