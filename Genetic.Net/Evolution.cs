using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic
{
    public class Evolution
    {
        private IRandomNumberGenerator random;
        private IChromosomeFactory chromosomeFactory;
        private IPopulationStrategy populationStrategy;
        private IMutationStrategy mutationStrategy;
        private ICrossoverStrategy crossoverStrategy;
        private ISelectionStrategy selectionStrategy;

        public Evolution(IRandomNumberGenerator random, 
            IChromosomeFactory chromosomeFactory, 
            IPopulationStrategy populationStrategy, 
            IMutationStrategy mutationStrategy,
            ICrossoverStrategy crossoverStrategy, 
            ISelectionStrategy selectionStrategy)
        {
            // TODO: Complete member initialization
            this.random = random;
            this.chromosomeFactory = chromosomeFactory;
            this.populationStrategy = populationStrategy;
            this.mutationStrategy = mutationStrategy;
            this.crossoverStrategy = crossoverStrategy;
            this.selectionStrategy = selectionStrategy;
        }
        
        public void Step()
        {
            throw new NotImplementedException();
        }

        public double TopFitness { get; set; }

        public int Generation { get; set; }
    }
}
