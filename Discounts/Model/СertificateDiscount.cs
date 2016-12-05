using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{


    /// <summary>
    /// Скидка по сертификату.
    /// </summary>

    [Serializable()]
    public class СertificateDiscount : Discount, IDiscount
    {
        /// <summary>
        /// беспараметрический конструктор,
        /// необходим для сериализации
        /// </summary>
        public СertificateDiscount() { }

        /// <summary>
        /// Размер скидки по сертификату.
        /// </summary>
        private double DiscountSize;

        public СertificateDiscount(double price, double discountSize)
        {
            this.Price = Math.Round(price, 2);
            if (discountSize < 0)
                throw new WrongSertificateException(discountSize);
            DiscountSize = discountSize;
            this.DiscountedPrice = this.GetDiscountedPrice(price);
        }

        /// <summary>
        /// Получение скидки
        /// </summary>
        /// <param name="price">Начальная цена</param>
        /// <returns>Цена со скидкой</returns>
        public double GetDiscountedPrice(double price)
        {
            return Math.Round(Math.Max(0, price - DiscountSize), 2);
        }
    }
}
