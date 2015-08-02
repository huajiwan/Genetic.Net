using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic
{
    public class FitnessComparisonResult
    {
        public FitnessComparisonResult(double fitnessA, double fitnessB, bool isAFitter, bool isBFitter, bool areEqual)
        {
            this.FitnessA = fitnessA;
            this.FitnessB = fitnessB;
            this.IsAFitter = isAFitter;
            this.IsBFitter = isBFitter;
            this.AreEqual = areEqual;
        }

        public double FitnessA { get; protected set; }
        public double FitnessB { get; protected set; }
        public bool IsAFitter { get; protected set; }
        public bool IsBFitter { get; protected set; }
        public bool AreEqual { get; protected set; }
    }
}
