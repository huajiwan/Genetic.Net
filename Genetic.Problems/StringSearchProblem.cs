using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Genetic.Problems
{
    /*
    * I would like to have an evolution algorithm
    * using sequence of characters as a representation
    * where each character can be in range a-Z.
    * Length of genome will be fixed to length of passphrase.
    * Fitness will be calculated as distance of genome to 'GenticAlgorithmsWorks'.
    * Mutation rate should be 1% and single-cut crossing should be applied.
    * For selection I would like to use 'keep fittest' strategy.
    * I would like population to be not bigger than 100 chromosomes per step.
    * 
    * It is expected to find a perfect match.
    * Stops after finding the match SUCCESS or timeouts after 1000 evolution steps as FAILURE.
    */
    [TestClass]
    public class StringSearchProblem
    {
        [TestMethod]
        public void SolveStringSearchProblem()
        {
            
        }
    }
}
