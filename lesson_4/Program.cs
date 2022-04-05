using System;

namespace lesson_4
{
    class Program
    {
        

        static void Main(string[] args)
        {
            bool k = false;
            do
            {
                (string userName, string userLastName, string userPatronymic) = GetFullName();
                Console.WriteLine($"{userLastName} {userName} {userPatronymic}");
                Console.WriteLine("Хотите продолжить?");
                string answer = Console.ReadLine();
                if (answer == "n")
                {
                    k = true;
                }
            }
            while (k == false);
            
        }

        static (string firstName, string lastName, string patronymic) GetFullName()
        {
            Console.WriteLine("Напишите имя");
            string firstName = Console.ReadLine();
            Console.WriteLine($"Напишите фамилию");
            string lastName = Console.ReadLine();
            Console.WriteLine($"Напишите отчетсво");
            string patronymic = Console.ReadLine();
            return (firstName, lastName, patronymic);
        }
    }
}
