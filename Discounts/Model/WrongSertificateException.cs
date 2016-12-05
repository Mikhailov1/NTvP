using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class WrongSertificateException : Exception
    {
        /// <summary>
        /// Ошибка при неправльном вводе данных о скидке по сертификату
        /// </summary>
        /// <param name="discount">Значение скидки по сертификату</param>
        public WrongSertificateException(double discount) :
            base("Скидка не может быть отрицательной, имеем скидку: " + discount.ToString())
        { }
    }
}