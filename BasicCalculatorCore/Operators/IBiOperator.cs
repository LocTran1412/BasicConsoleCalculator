using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCalculatorCore.Operators
{
    /// <summary>
    /// Toán tử hai ngôi
    /// </summary>
    interface IBiOperator
    {
        /// <summary>
        /// Tính toán giá trị của toán tử
        /// </summary>
        /// <param name="input1">Toán hạng thứ nhất</param>
        /// <param name="input2">Toán hạng thứ hai</param>
        /// <returns>Kết quả tính toán</returns>
        object Calc(object input1, object input2);
    }
}
