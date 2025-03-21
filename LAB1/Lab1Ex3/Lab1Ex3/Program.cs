using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            Temperatura temperatura = new Temperatura();
            Console.WriteLine("Temperatura in grade Celsius este " + temperatura.Celsius(x));
            Console.WriteLine("Temperatura in grade Farenheit este " + temperatura.Farenheit(x));
        }
    }
}
