using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Ex3
{
    internal class Temperatura
    {

        public double Farenheit(double x) {
            return x * 9 / 5 + 32;
        }
        public double Celsius(double x)
        {
            return (x - 32) * 5 / 9;
        }
    }
}
