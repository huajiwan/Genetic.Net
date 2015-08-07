using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic.Problems
{
    public class TravelingSalesmanCity
    {
        public TravelingSalesmanCity(char id, double x, double y)
        {
            this.Id = id;
            this.X = x;
            this.Y = y;
        }

        public char Id { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
    }
}
