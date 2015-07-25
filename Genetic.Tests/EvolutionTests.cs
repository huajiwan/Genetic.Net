using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Genetic.Tests
{
    [TestClass]
    public class EvolutionTests
    {
        /*[TestMethod]
        public void Constructor_CreatesInstance()
        {
            var mockPopulation = new Mock<IPopulation>();
            var mockSelectionStrategy = new Mock<ISelectionStrategy>();

            var evolution = new Evolution(mockPopulation, mockSelectionStrategy);
            Assert.IsNotNull(evolution);
        }

        [TestMethod]
        public void Step_MovesPopulationToNextEvolutionStep()
        {
            var mockPopulation = new Mock<IPopulation>();
            var mockSelectionStrategy = new Mock<ISelectionStrategy>();

            mockPopulation.SetupGet<int>((pop) => pop.Count).Returns(100);

            var evolution = new Evolution(mockPopulation, mockSelectionStrategy);
            
            Assert.AreEqual(0, evolution.Generation);

            evolution.Step();

            Assert.AreEqual(1, evolution.Generation);
        }*/
    }
}
