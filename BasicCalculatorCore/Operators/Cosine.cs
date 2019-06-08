using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCalculatorCore.Operators
{
    class Cosine : IOperable, IBiOperator
    {
        private object OpositeSide { get; set; }
        private object HypothenuseSide { get; set; }
        public object Calc(object OpositeSide, object HypothenuseSide)
        {
            this.OpositeSide = OpositeSide;
            this.HypothenuseSide = HypothenuseSide;
            if (OpositeSide == null || HypothenuseSide == null)
            {
                return null;
            }
            return (Double)OpositeSide / (Double)HypothenuseSide;
        }

        public string Info()
            => OpositeSide == null || HypothenuseSide == null ? "Invalid parameters" : $"Cosin({OpositeSide},{HypothenuseSide})=";
    }
}
