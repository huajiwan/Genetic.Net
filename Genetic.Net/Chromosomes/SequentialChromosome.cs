using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic.Chromosomes
{
    public class SequentialChromosome<T> : ISequentialChromosome<T>
    {
        private List<T> genes;
        public SequentialChromosome(IEnumerable<T> genes)
        {
            if (genes == null)
            {
                throw new ArgumentNullException("genes");
            }

            this.genes = new List<T>(genes);
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
