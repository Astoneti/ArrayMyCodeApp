using System;



namespace Arrays
{
    class Program
    {
        static void Main()
        {
            int[] array = new int[5];    // создание и инициализация

            // Заполнение массива.
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i * 2;   // Четные только
            }

            // Вывод на экран значений элементов массива.
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
                Console.ReadKey();
        }
    }
}
