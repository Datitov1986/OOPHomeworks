using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Model.Operations
{
    /// <summary>
    /// Интерфейс математических действий
    /// </summary>
    public interface IBaseOperations
    {
        /// <summary>
        /// Метод сложения чисел
        /// </summary>
        public Numbers sum (Numbers number);
        /// <summary>
        /// Метод вычитания чисел
        /// </summary>
        public Numbers sub (Numbers number);
        /// <summary>
        /// Метод умножения чисел
        /// </summary>
        public Numbers mult (Numbers number);
        /// <summary>
        /// Метод деления чисел
        /// </summary>
        public Numbers div (Numbers number);

    }
}