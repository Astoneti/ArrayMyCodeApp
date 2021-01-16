using System;
using System.Linq; // включаем фичу using System.Linq;

namespace ArrayMinMaxValue
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = {110 ,10, 2, 18, 98, 65, 199, 77, 999 };
            Console.WriteLine(myArray.Max());
            //  Вызываем метод Max и Min для вывода наибольшего и наи еньшего числа
            Console.WriteLine(myArray.Min());
            Console.ReadLine();
        }
           
    }
}
