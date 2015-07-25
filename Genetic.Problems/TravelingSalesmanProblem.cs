using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Genetic.Problems
{
    /*
    * I would like to have an evolution algorithm solving traveling salesman problem.
    * As problem is very hard to solve with numerous cities it will be limited to 10 for sake of the test.
    * 
    * Chromosome is a permutation of cities named A,B,C...
    * Length of genome will be fixed to number of cities.
    * Fitness will be calculated as total lenght of route through the cities, with favoring smallest value.
    * Mutation rate should be 2% and single-cut crossing should be applied.
    * For selection I would like to use 'roulete wheel' strategy.
    * I would like population to be not bigger than 50 chromosomes per step.
    * 
    * It is expected that algorithm will be able to find as good or better solution than the greedy algorithm.
    * Timeouts after 100 steps.
    */
    [TestClass]
    public class TravelingSalesmanProblem
    {
        [TestMethod]
        public void SolveTravelingSalesmanProblem()
        {
        }
    }
}
