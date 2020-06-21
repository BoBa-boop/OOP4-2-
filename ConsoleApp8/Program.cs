using System;

namespace ConsoleApp8
{
    class Book
    {
        private int Vypusk;
        public int Year
        {
            get
            {
                return Vypusk;
            }
            set
            {
                if (value < 1940 || value > 2020)
                {
                    Console.WriteLine("Год выпуска не попадает в диапозон");
                }
                else
                    Console.WriteLine("Год выпуска книги - " + value);
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Введите дату выхода книги");
                int year = int.Parse(Console.ReadLine());
                Book b = new Book();
                b.Year = year;
                Console.ReadKey();
            }
        }
    }
}
