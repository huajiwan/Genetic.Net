using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic.Problems
{
    public class SudokuFitnessCalculator : IFitnessCalculator<Chromosomes.ISequentialChromosome<int>>
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
