using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examen01_TI_GUERRERO_OLIVO.Interfaces;

namespace Examen01_TI_GUERRERO_OLIVO.Models
{
    public class SquareGO : ICalculateAreaGO
    {
        public double side;
        public double CalculateAreaGO() => side * side;
        public SquareGO(double side) => this.side = side;   


}
}