using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic.PopulationStrategies
{
    public class MultiPopulation : IPopulationStrategy
    {
        private int p1;
        private int p2;
        private MigrationStrategies.Random migrationStrategy;

        public MultiPopulation(int p1, int p2, MigrationStrategies.Random migrationStrategy)
        {
            // TODO: Complete member initialization
            this.p1 = p1;
            this.p2 = p2;
            this.migrationStrategy = migrationStrategy;
        }
    }
}
