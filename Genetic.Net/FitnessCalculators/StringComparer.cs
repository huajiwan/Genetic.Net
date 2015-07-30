using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Genetic.Chromosomes;

namespace Genetic.FitnessCalculators
{
    public class StringComparer : IFitnessCalculator<ISequentialChromosome<char>>
    {
        private string passphrase;

        public StringComparer(string passphrase)
        {
            // TODO: Complete member initialization
            this.passphrase = passphrase;
        }

        public double Calculate(ISequentialChromosome<char> chromosome)
        {
            throw new NotImplementedException();
        }
    }
}
