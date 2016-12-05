using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Model
{
    [Serializable(), XmlInclude(typeof(ProcentDiscount)), XmlInclude(typeof(СertificateDiscount))]
    public abstract class Discount
    {

        /// <summary>
        /// Цена товара без скидки
        /// </summary>
        double price;

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        /// <summary>
        /// Цена товара со скидкой
        /// </summary>
        double discountedPrice;
        
        public double DiscountedPrice
        {
            get { return discountedPrice; }
            set { discountedPrice = value; }
        }
        
    }
}
