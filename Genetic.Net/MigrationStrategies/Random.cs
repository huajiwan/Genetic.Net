using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic.MigrationStrategies
{
    public class Random : IMigrationStrategy
    {
        private RandomNumberGenerators.Default random;
        private double p;

        public Random(RandomNumberGenerators.Default random, double p)
        {
            // TODO: Complete member initialization
            this.random = random;
            this.p = p;
        }
    }
}
