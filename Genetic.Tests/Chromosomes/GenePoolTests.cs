using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Genetic.Chromosomes;

namespace Genetic.Tests.Chromosomes
{
    [TestClass]
    public class GenePoolTests
    {
        [TestMethod]
        public void Constructor_CreatesInstance()
        {
            GenePool<int> pool = new GenePool<int>();
            Assert.IsNotNull(pool);
            Assert.AreEqual(0, pool.Count);
        }

        [TestMethod]
        public void Add_AddsNewGene()
        {
            GenePool<int> pool = new GenePool<int>();
            pool.Add(10);

            Assert.AreEqual(1, pool.Count);
            Assert.AreEqual(10, pool[0]);

            pool.Add(5);

            Assert.AreEqual(2, pool.Count);
            Assert.AreEqual(10, pool[0]);
            Assert.AreEqual(5, pool[1]);
        }

        [TestMethod]
        public void Add_AddingGeneAlreadyInPool_GeneShouldntBeDuplicated()
        {
            GenePool<int> pool = new GenePool<int>();
            pool.Add(10);

            Assert.AreEqual(1, pool.Count);
            Assert.AreEqual(10, pool[0]);

            pool.Add(10);

            Assert.AreEqual(1, pool.Count);
            Assert.AreEqual(10, pool[0]);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddRange_ArgumentIsNull_ThrowsAnException()
        {
            GenePool < int > pool = new GenePool<int>();
            pool.AddRange(null);
            Assert.Fail();
        }

        [TestMethod]
        public void AddRange_AddsRangeOfGenes()
        {
            GenePool<int> pool = new GenePool<int>();
            pool.AddRange(new int[] { 10, 20, 30 });
            
            Assert.AreEqual(3, pool.Count);
            Assert.AreEqual(10, pool[0]);
            Assert.AreEqual(20, pool[1]);
            Assert.AreEqual(30, pool[2]);
        }

        [TestMethod]
        public void AddRange_AddsRangeOfGeneswithDuplicates_DuplicatesShouldBeSkipped()
        {
            GenePool<int> pool = new GenePool<int>();
            pool.AddRange(new int[] { 10, 10, 20, 20, 10, 20, 30, 30, 10, 20, 30, 10 });

            Assert.AreEqual(3, pool.Count);
            Assert.AreEqual(10, pool[0]);
            Assert.AreEqual(20, pool[1]);
            Assert.AreEqual(30, pool[2]);
        }
    }
}
