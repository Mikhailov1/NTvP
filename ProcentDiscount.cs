using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class WrongProcentException : Exception
    {
        public WrongProcentException(double procent) : 
            base("Скидка должна быть в пределах от 0% до 100%, имеем скидку: " + procent.ToString() + "%")
        { }
    }

    /// <summary>
    /// Процентная скидка
    /// </summary>
    public class ProcentDiscount : IDiscount
    {
        /// <summary>
        /// Размер скидки в процентах.
        /// </summary>
        private double _procent = 0;

        /// <summary>
        /// Размер скидки в процентах.
        /// </summary>
        public double Procent
        {
            set
            {
                if (value > 100 || value < 0)
                    throw new WrongProcentException(value);
                _procent = value;
            }

            get
            {
                return _procent;
            }
        }

        /// <summary>
        /// Получение скидки
        /// </summary>
        /// <param name="price">Начальная цена</param>
        /// <returns>Цена со скидкой</returns>
        public double GetDiscountedPrice(double price)
        {
            return price * ((100.0 - _procent) / 100.0);
        }
    }
}
