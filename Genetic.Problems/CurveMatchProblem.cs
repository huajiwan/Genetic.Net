using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Genetic.Problems
{
    /*
    * I would like to have an evolution algorithm
    * able to find equation of a curve which goes through list of given points in 2D space.
    * 
    * Chromosome should represent expression tree.
    * Length of genome should be varied and can - and should - change.
    * Fitness will be calculated as sum of differences between generated equation results and given samples.
    * Mutation rate should be 1% and single-cut crossing should be applied.
    * For selection I would like to use roulete wheel strategy.
    * I would like population to be not bigger than 50 chromosomes per step.
    * 
    * It is expected to find a perfect match.
    * Stops after finding the match SUCCESS or timeouts after 500 evolution steps as FAILURE.
    */
    [TestClass]
    public class CurveMatchProblem
    {
        [TestMethod]
        public void SolveCurveMatchProblem()
        {
            
        }
    }
}
