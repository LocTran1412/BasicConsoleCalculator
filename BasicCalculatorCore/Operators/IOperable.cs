using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCalculatorCore.Operators
{
    /// <summary>
    /// Khả năng tính toán
    /// </summary>
    interface IOperable
    {
        /// <summary>
        /// Lấy thông tin toán tử
        /// </summary>
        /// <returns></returns>
        string Info();
    }
}
