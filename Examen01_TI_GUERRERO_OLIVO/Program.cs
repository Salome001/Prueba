using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examen01_TI_GUERRERO_OLIVO.Models;
using Examen01_TI_GUERRERO_OLIVO.Services;

namespace Examen01_TI_GUERRERO_OLIVO
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new ShapeCalculatorGO();

            Console.WriteLine("Circle: ");

            var circle = new CircleGO(5);
            calculator.printAreaGO(circle);

            Console.WriteLine("Cuadrade: ");

            var square = new SquareGO(4);
            calculator.printAreaGO(square);

            Console.WriteLine("Sphere: ");
            var shpere = new SphereGO(3);
            calculator.printVolumeGo(shpere);
            calculator.printAreaGO(shpere);

            Console.WriteLine("Cube: ");
            var cube = new CubeGO(2);
            calculator.printVolumeGo(cube);
            calculator.printAreaGO(cube);





        }
    }
}
