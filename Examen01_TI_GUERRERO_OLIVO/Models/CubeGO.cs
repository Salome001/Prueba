using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examen01_TI_GUERRERO_OLIVO.Interfaces;

namespace Examen01_TI_GUERRERO_OLIVO.Models
{
    public class CubeGO: ICalculateAreaGO, ICalculateVolumeGO
    {
        public double edge;
        public CubeGO(double edge) => this.edge = edge; 
      public double CalculateVolumeGO() => Math.Pow(edge,3);
       
        public double CalculateAreaGO() =>  6 * edge* edge;
        
        
    }
}
