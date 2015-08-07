using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic.Problems
{
    public class TravelingSalesmanProblemFitnessCalculator : IFitnessCalculator<Chromosomes.IPermutationChromosome<char>>
    {
        private List<TravelingSalesmanCity> citiesCoordinates;

        public TravelingSalesmanProblemFitnessCalculator(IEnumerable<TravelingSalesmanCity> citiesCoordinates)
        {
            this.citiesCoordinates = new List<TravelingSalesmanCity>(citiesCoordinates);
        }

        public double Calculate(Chromosomes.IPermutationChromosome<char> chromosome)
        {
            if (chromosome.Length != citiesCoordinates.Count)
            {
                throw new ArgumentOutOfRangeException("chromosome");
            }

            double totalDistance = 0;
            for (int i = 0; i < chromosome.Length; i++)
            {
                if (i + 1 < chromosome.Length)
                {
                    totalDistance += this.CalcDistance(chromosome[i], chromosome[i + 1]);
                }
                else
                {
                    totalDistance += this.CalcDistance(chromosome[i], chromosome[0]);
                }
            }

            return totalDistance;
        }

        public FitnessComparisonResult Compare(double fitnessA, double fitnessB)
        {
            return new FitnessComparisonResult(
                fitnessA,
                fitnessB,
                fitnessA < fitnessB,
                fitnessB < fitnessA,
                fitnessA == fitnessB);
        }

        private double CalcDistance(char aId, char bId)
        {
            return this.CalcDistance(
                this.citiesCoordinates.FirstOrDefault(x => x.Id == aId),
                this.citiesCoordinates.FirstOrDefault(x => x.Id == bId));
        }

        private double CalcDistance(TravelingSalesmanCity a, TravelingSalesmanCity b)
        {
            return Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
        }
    }
}
