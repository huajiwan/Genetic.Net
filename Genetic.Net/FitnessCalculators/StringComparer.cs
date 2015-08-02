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
            if (string.IsNullOrEmpty(passphrase))
            {
                throw new ArgumentNullException("passpharase");
            }

            this.passphrase = passphrase;
        }

        public double Calculate(ISequentialChromosome<char> chromosome)
        {
            if (chromosome.Length != this.passphrase.Length)
            {
                throw new ArgumentOutOfRangeException("chromosome");
            }

            double matchCount = 0;
            for (int i = 0; i < chromosome.Length; i++)
            {
                if (chromosome[i] == this.passphrase[i])
                {
                    matchCount++;
                }
            }

            return matchCount / this.passphrase.Length;
        }

        public FitnessComparisonResult Compare(double fitnessA, double fitnessB)
        {
            return new FitnessComparisonResult(
                fitnessA, 
                fitnessB,
                fitnessA > fitnessB,
                fitnessB > fitnessA,
                fitnessA == fitnessB);
        }
    }
}
