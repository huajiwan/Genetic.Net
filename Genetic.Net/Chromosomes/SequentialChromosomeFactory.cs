using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic.Chromosomes
{
    public class SequentialChromosomeFactory<T> : IChromosomeFactory
    {
        private RandomNumberGenerators.Default random;
        private GenePool<T> genePool;
        private int p;

        public SequentialChromosomeFactory(RandomNumberGenerators.Default random, GenePool<T> genePool, int p)
        {
            // TODO: Complete member initialization
            this.random = random;
            this.genePool = genePool;
            this.p = p;
        }
    }
}
