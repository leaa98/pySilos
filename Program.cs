using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pySilos
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine("Introduzca la altura del silo");
            double altura = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine("Introduzca el diametro de la base del silo");
            double diametroCircular = Convert.ToDouble(Console.ReadLine());
            Silo silo1 = new Silo(altura, diametroCircular);
            System.Console.WriteLine("El volumen total del silo es de " + silo1.calcularVolumen()+" cm2");
            Console.ReadKey();
        }
    }
}
