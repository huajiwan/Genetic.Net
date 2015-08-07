using System;
using Genetic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Genetic.Problems
{
    /*
    * I would like to have an evolution algorithm solving sudoku problem.
    * Will use empty 9x9 sudoku board.
    * 
    * Chromosome is using sequence of numbers from 1 to 9 as a gene allowed values.
    * Length of genome will be fixed to number of slots in the 9x9 sudoku board.
    * Fitness will be calculated as a number of valid rows + number of valid cells + number of valid squares.
    * All standard sudoku rules apply (numbers must be distinct in each row, column and subsquare)
    * Mutation rate should be 0.5% and double-cut crossing should be applied.
    * For selection I would like to use 'tournament' strategy.
    * I would like population to be not bigger than 250 chromosomes per step.
    * 
    * It is expected that it will find sudoku solution before 100 evolution step.
    */
    [TestClass]
    public class SudokuProblem
    {       

        [TestMethod]
        public void SolveSudokuProblem()
        {
            var random = new RandomNumberGenerators.Default();

            var genePool = new Chromosomes.GenePool<int>();
            genePool.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });

            var chromosomeFactory = new Chromosomes.SequentialChromosomeFactory<int>(random, genePool, 81); // chromosome as a sequence with 81 1-9 numbers
            var fitnessCalc = new SudokuFitnessCalculator();
            var mutationStrategy = new MutationStrategies.SingleGeneMutation(random, 0.005); // mutation rate fixed to 0.5%
            var crossoverStrategy = new CrossoverStrategies.DoubleCut(random);
            var selectionStrategy = new SelectionStrategies.Tournament();
            var populationStrategy = new PopulationStrategies.SinglePopulation(250); // size fixed to 250

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
            while (evolution.Generation < 100);
            Assert.Fail();
        }
    }    
}
