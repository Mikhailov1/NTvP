using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace ConsoleLoader
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IDiscount ds1 = new ProcentDiscount();
                Console.WriteLine("Введите размер скидки в процентах");
                double procent = Convert.ToDouble(Console.ReadLine());
                ((ProcentDiscount)ds1).Procent = procent;
                Console.WriteLine("Введите цену товара");
                double price = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Цена товара со скидкой : {0}", ds1.GetDiscountedPrice(price));
            }
            catch(FormatException fe)
            {
                Console.WriteLine(fe.Message);
            }
            catch(WrongProcentException wpe)
            {
                Console.WriteLine(wpe.Message);
            }

            try
            {
                IDiscount ds2 = new SertificateDiscount();
                Console.WriteLine("Введите размер скидки по сертификату");
                double discountSize = Convert.ToDouble(Console.ReadLine());
                ((SertificateDiscount)ds2).DiscountSize = discountSize;
                Console.WriteLine("Введите цену товара");
                double price = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Цена товара со скидкой : {0}", ds2.GetDiscountedPrice(price));
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
            }
            catch (WrongSertificateException wse)
            {
                Console.WriteLine(wse.Message);
            }
        }
    }
}
