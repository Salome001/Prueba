using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examen01_TI_GUERRERO_OLIVO.Interfaces;

namespace Examen01_TI_GUERRERO_OLIVO.Services
{
    public class ShapeCalculatorGO
    {
        public void printAreaGO(ICalculateAreaGO shape)
        {
            Console.WriteLine("Area: {0:F2}", shape.CalculateAreaGO());

        }

        public void printVolumeGo(ICalculateVolumeGO shape)
        {
            Console.WriteLine("Volume: {0:F2}", shape.CalculateVolumeGO());
        }
    }
}
