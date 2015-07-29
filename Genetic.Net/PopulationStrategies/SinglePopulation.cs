using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic.PopulationStrategies
{
    public class SinglePopulation : IPopulationStrategy
    {
        private int p;

        public SinglePopulation(int p)
        {
            // TODO: Complete member initialization
            this.p = p;
        }
    }
}
