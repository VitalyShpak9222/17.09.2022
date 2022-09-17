using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KW_at_17_09_2022
{
    class Program
    {
        struct Person
        {
            public string firstname;
            public string surname;
            public int identifier;
            public char category_alcohol;
            public int volume;

            public void Print()
            {
                Console.WriteLine($"Имя: {firstname}  Фамилия: {surname} Индификатор: {identifier} Категория: {category_alcohol} Объем выпитого {volume}");
            }
        }
        static void Main(string[] args)
        {

        }
    }
}
