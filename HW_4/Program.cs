using System;

namespace HW_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Числа Фибоначчи");
            Console.WriteLine("Напишите значение");
            int num = Convert.ToInt32(Console.ReadLine());
            string fib = "0 1 ";
            fib += Fibonacci(num, 0, 1);
            Console.WriteLine($"Ряд чисел {fib}");
        }


        static string Fibonacci(int num, int firstNum, int secondNum)
        {
            string result = "";
            if (num <= 1)
            {
                return result;
            }
            result = $"{firstNum + secondNum} ";
            return result + Fibonacci(num - 1, secondNum, firstNum + secondNum);

        }


    }
}
