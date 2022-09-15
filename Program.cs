using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exchange
{
    class Program
    {
        static void Main(string[] args)
        {
            var rate = 60.47;
            var summa = 0.0;
            var result = 0.0;
            var resume = "Да";
            while (resume == "Да")
            {
                Console.Write("Введите количество входящих единиц: ");
                summa = ushort.Parse(Console.ReadLine());
                if (summa <= 8)
                {
                    Console.WriteLine("Вы не можете вводить количество единиц меньше или равную 8!");
                    continue;
                }
                if (summa < 500)
                {
                    Console.WriteLine("Комиссия: 8 единиц");
                    summa = summa - 8;
                    result = summa * rate;
                    Console.WriteLine("Конвертированная сумма: {0:f2}", result);
                }
                else
                {
                    Console.WriteLine("Комиссия: {0:f2} едениц", summa * 0.0037);
                    result = summa - (summa * 0.0037);
                    Console.WriteLine("Конвертированная сумма: {0:f2}", result * rate);
                }
                Console.WriteLine("Желаете продолжить?");
                resume = Console.ReadLine();
            } 
            Console.ReadKey();
        }
    }
}