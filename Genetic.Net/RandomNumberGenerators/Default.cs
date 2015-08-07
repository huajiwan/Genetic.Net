using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic.RandomNumberGenerators
{
    public class Default : IRandomNumberGenerator
    {
        private Random random = new Random((int)DateTime.Now.Ticks);

        public double Next()
        {
            return random.NextDouble();
        }
    }
}
