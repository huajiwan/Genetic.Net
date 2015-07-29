using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic.MutationStrategies
{
    public class SingleGeneMutation : IMutationStrategy
    {
        private RandomNumberGenerators.Default random;
        private double p;

        public SingleGeneMutation(RandomNumberGenerators.Default random, double p)
        {
            // TODO: Complete member initialization
            this.random = random;
            this.p = p;
        }

        public IChromosome Mutate(IChromosome chromosome)
        {
            throw new NotImplementedException();
        }
    }
}
