using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Процентная скидка
    /// </summary>

    [Serializable()]
    public class ProcentDiscount : Discount, IDiscount
    {
        /// <summary>
        /// беспараметрический конструктор,
        /// необходим для сериализации
        /// </summary>
        public ProcentDiscount() { }

        /// <summary>
        /// Размер скидки в процентах.
        /// </summary>
        private double Procent;

        public ProcentDiscount(double price, double procent)
        {
            Price = Math.Round(price, 2);
            if (procent > 100 || procent < 0)
                throw new WrongProcentException(procent);
            Procent = procent;
            DiscountedPrice = this.GetDiscountedPrice(price);
        }

        /// <summary>
        /// Получение скидки
        /// </summary>
        /// <param name="price">Начальная цена</param>
        /// <returns>Цена со скидкой</returns>
        public double GetDiscountedPrice(double price)
        {
            return Math.Round(price * ((100.0 - Procent) / 100.0), 2);
        }
    }
}
