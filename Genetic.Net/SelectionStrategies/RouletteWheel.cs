using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic.SelectionStrategies
{
    public class RouletteWheel : ISelectionStrategy
    {
        private RandomNumberGenerators.Default random;

        public RouletteWheel(RandomNumberGenerators.Default random)
        {
            // TODO: Complete member initialization
            this.random = random;
        }
        public void Select()
        {
            throw new NotImplementedException();
        }
    }
}
