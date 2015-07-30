using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic.Chromosomes
{
    public class PermutationChromosomeFactory<T> : IChromosomeFactory
    {
        private RandomNumberGenerators.Default random;
        private GenePool<char> genePool;
        private int p;

        public PermutationChromosomeFactory(RandomNumberGenerators.Default random, GenePool<char> genePool, int p)
        {
            // TODO: Complete member initialization
            this.random = random;
            this.genePool = genePool;
            this.p = p;
        }
    }
}
