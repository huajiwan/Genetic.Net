using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Genetic.Problems
{
    [TestClass]
    public class TravelingSalesmanProblemFitnessCalculatorTests
    {
        [TestMethod]
        public void ValiadateTravelingSalesmanProblemFitnessCalculator_WithKnownDistance()
        {
            var cities = new List<TravelingSalesmanCity>() {
                new TravelingSalesmanCity('A', 0, 0),
                new TravelingSalesmanCity('B', 0, 10),
                new TravelingSalesmanCity('C', 10, 10),
                new TravelingSalesmanCity('D', 10, 0)
            };

            var calculator = new TravelingSalesmanProblemFitnessCalculator(cities);
            var distance = calculator.Calculate(new Chromosomes.PermutationChromosome<char>("ABCD".ToCharArray()));
            Assert.AreEqual(40, distance);
        }

        [TestMethod]
        public void ValiadateTravelingSalesmanProblemFitnessCalculator_ComparerCheck()
        {
            var calculator = new TravelingSalesmanProblemFitnessCalculator(new List<TravelingSalesmanCity>());
            var compResult = calculator.Compare(1000, 2000);
            Assert.AreEqual(1000.0, compResult.FitnessA);
            Assert.AreEqual(2000.0, compResult.FitnessB);
            Assert.IsTrue(compResult.IsAFitter);
            Assert.IsFalse(compResult.IsBFitter);
            Assert.IsFalse(compResult.AreEqual);
        }
    }    
}
