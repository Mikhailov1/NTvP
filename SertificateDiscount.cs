using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class WrongSertificateException : Exception
    {
        public WrongSertificateException(double discount) :
            base("Скидка не может быть отрицательной, имеем скидку: " + discount.ToString())
        { }
    }

    /// <summary>
    /// Скидка по сертификату.
    /// </summary>
    public class SertificateDiscount : IDiscount
    {
        /// <summary>
        /// Размер скидки по сертификату.
        /// </summary>
        private double _discountSize = 0;

        /// <summary>
        /// Размер скидки по сертификату.
        /// </summary>
        public double DiscountSize
        {
            set
            {
                if (value < 0)
                    throw new WrongSertificateException(value);
                _discountSize = value;
            }

            get
            {
                return _discountSize;
            }
        }

        /// <summary>
        /// Получение скидки
        /// </summary>
        /// <param name="price">Начальная цена</param>
        /// <returns>Цена со скидкой</returns>
        public double GetDiscountedPrice(double price)
        {
            return Math.Max(0, price - _discountSize);
        }
    }
}
