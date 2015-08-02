using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic.Chromosomes
{
    public class PermutationChromosome<T> : IPermutationChromosome<T>
    {
        private List<T> genes;
        public PermutationChromosome(IEnumerable<T> genes)
        {
            if(genes == null)
            {
                throw new ArgumentNullException("genes");
            }

            this.genes = new List<T>(genes);
            // TODO : validate here wheter genes are uniqe as permutation does not allow genes to repeat
        }

        public int Length
        {
            get
            {
                return this.genes.Count;
            }
        }

        public T this[int index]
        {
            get
            {
                return this.genes[index];
            }           
        }
    }
}
