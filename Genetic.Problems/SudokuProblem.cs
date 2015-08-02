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

        [TestMethod]
        public void ValiadateSudokuFitnessCalculator_WithSolvedSudoku()
        {
            SudokuFitnessCalculator calculator = new SudokuFitnessCalculator();
            int[] solvedSudokuNumbers = new int[] {
                8,3,5,   4,1,6,   9,2,7,
                2,9,6,   8,5,7,   4,3,1,
                4,1,7,   2,9,3,   6,5,8,

                5,6,9,   1,3,4,   7,8,2,
                1,2,3,   6,7,8,   5,4,9,
                7,4,8,   5,2,9,   1,6,3,

                6,5,2,   7,8,1,   3,9,4,
                9,8,1,   3,4,5,   2,7,6,
                3,7,4,   9,6,2,   8,1,5
            };
            var chromosome = new Chromosomes.SequentialChromosome<int>(solvedSudokuNumbers);
            Assert.AreEqual(1.0, calculator.Calculate(chromosome));
        }

        [TestMethod]
        public void ValiadateSudokuFitnessCalculator_WithUnsolvedSudoku()
        {
            SudokuFitnessCalculator calculator = new SudokuFitnessCalculator();
            int[] unsolvedSudokuNumbers = new int[] {
                1,1,1,   1,1,1,   1,1,1,
                1,1,1,   1,1,1,   1,1,1,
                1,1,1,   1,1,1,   1,1,1,

                1,1,1,   1,1,1,   1,1,1,
                1,1,1,   1,1,1,   1,1,1,
                1,1,1,   1,1,1,   1,1,1,

                1,1,1,   1,1,1,   1,1,1,
                1,1,1,   1,1,1,   1,1,1,
                1,1,1,   1,1,1,   1,1,1
            };
            var chromosome = new Chromosomes.SequentialChromosome<int>(unsolvedSudokuNumbers);
            Assert.AreEqual(0.0, calculator.Calculate(chromosome));
        }
    }

    class SudokuFitnessCalculator : IFitnessCalculator<Chromosomes.ISequentialChromosome<int>>
    {
        public double Calculate(Chromosomes.ISequentialChromosome<int> chromosome)
        {
            if (chromosome.Length != 81)
            {
                throw new ArgumentOutOfRangeException("chromosome");
            }

            int targetSum = 1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9;
            int targetMul = 1 * 2 * 3 * 4 * 5 * 6 * 7 * 8 * 9;
            int[] columnSum = new int[9];
            int[] rowSum = new int[9];
            int[] squareSum = new int[9];
            int[] columnMul = new int[9];
            int[] rowMul = new int[9];
            int[] squareMul = new int[9];
            for (int i = 0; i < 9; i++)
            {
                columnMul[i] = 1;
                rowMul[i] = 1;
                squareMul[i] = 1;
            }

            int column = 0;
            int row = 0;
            int square = 0;
            for (int i = 0; i < chromosome.Length; i++)
            {
                column = i / 9;
                row = i % 9;
                square = 3 * (row / 3) + column / 3;
                
                rowSum[row] += chromosome[i];
                columnSum[row] += chromosome[i];
                squareSum[square] += chromosome[i];
                rowMul[row] *= chromosome[i];
                columnMul[row] *= chromosome[i];
                squareMul[square] *= chromosome[i];
                column++;
            }

            int score = 0;
            foreach (int sum in columnSum)
                if (sum == targetSum)
                    score++;
            foreach (int sum in rowSum)
                if (sum == targetSum)
                    score++;
            foreach (int sum in squareSum)
                if (sum == targetSum)
                    score++;
            foreach (int mul in columnMul)
                if (mul == targetMul)
                    score++;
            foreach (int mul in rowMul)
                if (mul == targetMul)
                    score++;
            foreach (int mul in squareMul)
                if (mul == targetMul)
                    score++;
            double maxScore = 2 * (9 + 9 + 9);
            return score / maxScore;
        }
    }
}
