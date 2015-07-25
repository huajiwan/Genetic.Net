using System;
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
        }
    }
}
