using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public interface IDiscount
    {
        /// <summary>
        /// Получение скидки
        /// </summary>
        /// <param name="price">Начальная цена</param>
        /// <returns>Цена со скидкой</returns>
        double GetDiscountedPrice(double price);
    }
}
