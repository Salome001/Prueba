using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examen01_TI_GUERRERO_OLIVO.Interfaces;

namespace Examen01_TI_GUERRERO_OLIVO.Models
{
    public class CircleGO: ICalculateAreaGO
    {
        private double radius;
        public CircleGO(double radius)=> this.radius = radius;

        public double CalculateAreaGO()=>Math.PI*radius*radius;

        
    }
}
