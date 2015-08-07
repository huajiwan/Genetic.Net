using System;
using Genetic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Genetic.Problems
{
    [TestClass]
    public class SudokuFitnessCalculatorTests
    {
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

        [TestMethod]
        public void ValiadateSudokuFitnessCalculator_ComparerCheck()
        {
            SudokuFitnessCalculator calculator = new SudokuFitnessCalculator();
            var compResult = calculator.Compare(0.75, 0.5);
            Assert.AreEqual(0.75, compResult.FitnessA);
            Assert.AreEqual(0.5, compResult.FitnessB);
            Assert.IsTrue(compResult.IsAFitter);
            Assert.IsFalse(compResult.IsBFitter);
            Assert.IsFalse(compResult.AreEqual);
        }
    }
}
