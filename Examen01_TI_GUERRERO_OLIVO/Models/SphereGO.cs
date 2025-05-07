using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examen01_TI_GUERRERO_OLIVO.Interfaces;

namespace Examen01_TI_GUERRERO_OLIVO.Models
{
    public class SphereGO : ICalculateAreaGO, ICalculateVolumeGO
    {
        public double radius;
        public SphereGO(double radius) => this.radius = radius;
        
        public double CalculateAreaGO() => 4 * Math.PI * radius * radius;


        public double CalculateVolumeGO()
            => (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
      
        }
    }
