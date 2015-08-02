using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic.Chromosomes
{
    public class SequentialChromosome<T> : ISequentialChromosome<T>
    {
        public SequentialChromosome(IEnumerable<T> initializingSet)
        {

        }

        public int Length
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public T this[int index]
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
