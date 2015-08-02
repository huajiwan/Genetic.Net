using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic.Chromosomes
{
    public interface ISequentialChromosome<T> : IChromosome
    {
        int Length { get; }
        T this[int index] { get; }
    }
}
