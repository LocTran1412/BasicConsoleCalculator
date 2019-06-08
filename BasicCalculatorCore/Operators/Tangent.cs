using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCalculatorCore.Operators
{
    class Tangent : IOperable, IBiOperator
    {
        private object OpositeSide { get; set; }
        private object AdjacentSide { get; set; }
        public object Calc(object OpositeSide, object AdjacentSide)
        {
            this.OpositeSide = OpositeSide;
            this.AdjacentSide = AdjacentSide;
            if (OpositeSide == null || AdjacentSide == null)
            {
                return null;
            }
            return (Double)OpositeSide / (Double)AdjacentSide;
        }

        public string Info()
            => OpositeSide == null || AdjacentSide == null ? "Invalid parameters" : $"Tangent({OpositeSide},{AdjacentSide})=";
    }
}
