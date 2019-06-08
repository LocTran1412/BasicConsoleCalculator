using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCalculatorCore.Operators
{
    /// <summary>
    /// Toán tử một ngôi
    /// </summary>
    interface IMonoOperator
    {
        /// <summary>
        /// Tính toán toán tử một ngôi
        /// </summary>
        /// <param name="input">Giá trị truyền vào</param>
        /// <returns>Kết quả phép tính</returns>
        object Calc(object input);
    }
}
