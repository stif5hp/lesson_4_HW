using System;

namespace HW_3
{
    class Program
    {
        enum Season
        {
            Spring,
            Summer,
            Autumn,
            Winter
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Напишите номер месяца");
            int month = Convert.ToInt32(Console.ReadLine());
            Season season = default;
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    season = Season.Winter;
                    break;
                case 3:
                case 4:
                case 5:
                    season = Season.Spring;
                    break;
                case 6:
                case 7:
                case 8:
                    season = Season.Summer;
                    break;
                case 9:
                case 10:
                case 11:
                    season = Season.Autumn;
                    break;
                default:
                    Console.WriteLine("Укажите значение от 1 до 12");
                    break;
            }
            Console.WriteLine(season.ToString());

        }
    }
}
