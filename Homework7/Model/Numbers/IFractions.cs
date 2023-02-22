using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Model.Numbers
{
    /// <summary>
    /// Интерфейс обыкновенных дробей
    /// </summary>
    public interface IFractions
    {
        /// <summary>
        /// метод, возвращающий числитель дроби
        /// </summary>
        public double getNumerator();

        /// <summary>
        /// метод, возвращающий знаменатель дроби
        /// </summary>
        public double getDenominator();
    }
}