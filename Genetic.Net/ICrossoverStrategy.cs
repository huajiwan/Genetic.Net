using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic
{
    public interface ICrossoverStrategy<T>
        where T : IChromosome
    {
        List<T> Cross(T chromosomeA, T chromosomeB);
    }
}
