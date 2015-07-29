using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic
{
    public interface ISequentialChromosome<T> : IChromosome
    {
        int Length { get; set; }
        T this[int index] { get; set; }
    }
}
