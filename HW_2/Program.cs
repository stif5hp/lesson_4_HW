using System;

namespace HW_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напищите числа через пробел");
            string numbers = Console.ReadLine();
            string[] array = numbers.Split();
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += Convert.ToInt32(array[i]);
            }
            Console.WriteLine(sum);
        }
    }
}
