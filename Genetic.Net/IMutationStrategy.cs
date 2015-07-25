using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic
{
    public interface IMutationStrategy<T>
        where T : IChromosome
    {
        T Mutate(T chromosome);
    }
}
