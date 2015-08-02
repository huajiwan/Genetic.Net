using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic
{
    public interface IFitnessCalculator<T>
        where T : IChromosome
    {
        double Calculate(T chromosome);
        FitnessComparisonResult Compare(double fitnessA, double fitnessB);
    }
}
