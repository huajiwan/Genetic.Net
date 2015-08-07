using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic.Chromosomes
{
    /// <summary>
    /// Geen pool is a set of genes available for creating the chromosomes.
    /// Each gene in the pool must be distinct.
    /// </summary>
    /// <typeparam name="T">Gene implementing type</typeparam>
    public class GenePool<T>
    {
        private List<T> genes = new List<T>();

        public void AddRange(IEnumerable<T> geeneColection)
        {
            foreach(var gene in geeneColection)
            {
                this.Add(gene);
            }
        }

        public void Add(T gene)
        {
            if (!this.genes.Contains(gene))
            {
                this.genes.Add(gene);
            }
        }

        public int Count
        {
            get
            {
                return this.genes.Count;
            }
        }

        public T this[int index]
        {
            get
            {
                return this.genes[index];
            }
        }
    }
}
