using System;
using Genetic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Genetic.Problems
{
    /*
    * I would like to have an evolution algorithm
    * using sequence of characters as a representation
    * where each character can be in range a-Z and !.
    * Length of genome will be fixed to length of passphrase.
    * Fitness will be calculated as distance of genome to 'GenticAlgorithmsWorks!'.
    * 
    * Mutation rate should be 1% and single-cut crossing should be applied.
    * For selection I would like to use 'keep most fit' strategy.
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
            string passphrase = "GenticAlgorithmsWorks!";
            var random = new RandomNumberGenerators.Default();

            var genePool = new Chromosomes.GenePool<char>();
            genePool.AddRange("abcdefghijklmnopqrstuvwxyz".ToCharArray());
            genePool.AddRange("ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray());
            genePool.Add('!');
                        
            var chromosomeFactory = new Chromosomes.SequentialChromosomeFactory<char>(random, genePool, passphrase.Length); // chromosome as fixed lenght sequence with array of allowed characters
            var fitnessCalc = new FitnessCalculators.StringComparer(passphrase);
            var mutationStrategy = new MutationStrategies.SingleGeneMutation(random, 0.01); // mutation rate fixed to 1%
            var crossoverStrategy = new CrossoverStrategies.SingleCut(random);
            var selectionStrategy = new SelectionStrategies.KeepFittest();
            var populationStrategy = new PopulationStrategies.SinglePopulation(100); // size fixed to 100

            var evolution = new Evolution(random, 
                chromosomeFactory,
                populationStrategy,
                mutationStrategy,
                crossoverStrategy,
                selectionStrategy);

            do
            {
                evolution.Step();
                if (evolution.TopFitness == 1.0)
                {
                    return;
                }
            }
            while (evolution.Generation < 1000);
            Assert.Fail();
        }
    }
}
