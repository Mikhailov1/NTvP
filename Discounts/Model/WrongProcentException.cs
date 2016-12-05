using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class WrongProcentException : Exception
    {
        /// <summary>
        /// Ошибка при неправльном вводе данных о % скидке
        /// </summary>
        /// <param name="procent">Значение скидки по %</param>
        public WrongProcentException(double procent) :
            base("Скидка должна быть в пределах от 0% до 100%, имеем скидку: " + procent.ToString() + "%")
        { }
    }
}