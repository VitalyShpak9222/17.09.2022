using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KW_at_17_09_2022
{
    class Program
    {
        struct vacation
        {
            public int normPrice;
            public int salePrice;
            public int holidayPrice;
            public int Print()
            {
                return normPrice * salePrice / 100;
            }
        }
        struct personal_data
        {
            public string name;
            public string city;
            public string age;
            public string PIN;
            public string Print()
            {
                return $"Имя: {name} Возраст: {age} город: {city} PIN: {PIN}";
            }
        }
        struct type_data
        {
            public string typename;
            public long minznach;
            public ulong maxznach;
            public string Print()
            {
                return $"Тип данных: {typename} максимальное значение {maxznach} минимальное значение: {minznach}";
            }
            struct Student
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
                Console.WriteLine("Задание 1");
                Console.WriteLine("Необходимо создать 5 структур типа Student и вычислить процентную часть выпитого");
                Student Maxim = new Student();
                Maxim.firstname = "Максим";
                Maxim.surname = "Романов";
                Maxim.identifier = 1;
                Maxim.category_alcohol = 'b';
                Maxim.volume = 872;
                Student Ilia = new Student();
                Ilia.firstname = "Илья";
                Ilia.surname = "Колобков";
                Ilia.identifier = 2;
                Ilia.category_alcohol = 'c';
                Ilia.volume = 1238;
                Student Renat = new Student();
                Renat.firstname = "Ренат";
                Renat.surname = "Ахмеджан";
                Renat.identifier = 3;
                Renat.category_alcohol = 'a';
                Renat.volume = 820;
                Student Karim = new Student();
                Karim.firstname = "Карим";
                Karim.surname = "Мусаголиев";
                Karim.identifier = 4;
                Karim.category_alcohol = 'd';
                Karim.volume = 243;
                Student Kamila = new Student();
                Kamila.firstname = "Камила";
                Kamila.surname = "Уткина";
                Kamila.identifier = 5;
                Kamila.category_alcohol = 'a';
                Kamila.volume = 68;
                double alkovolume = Maxim.volume + Ilia.volume + Renat.volume + Karim.volume + Kamila.volume;
                Console.WriteLine("Общий объем выпитого алкоголя равен " + alkovolume + "\nМаксим выпил " + (Maxim.volume / alkovolume + "\nИлья выпил " + (Ilia.volume / alkovolume) + "\r\nРенат выпил " + (Renat.volume / alkovolume) + "\r\nКарим выпил " + (Karim.volume / alkovolume) + "\r\nКамила выпила " + (Kamila.volume / alkovolume)));
                Console.WriteLine("Для перехода к следующему решению нажмите enter");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Задание 2\r\nНеобходимо вывести информацию о всех типах двнных с доп.информацией");
                type_data byte_t = new type_data();
                byte_t.typename = "byte";
                byte_t.minznach = 0;
                byte_t.maxznach = 255;
                type_data sbyte_t = new type_data();
                sbyte_t.typename = "sbyte";
                sbyte_t.minznach = -128;
                sbyte_t.maxznach = 127;
                type_data short_t = new type_data();
                short_t.typename = "short";
                short_t.minznach = -32768;
                short_t.maxznach = 32767;
                type_data ushort_t = new type_data();
                ushort_t.typename = "ushort";
                ushort_t.minznach = 0;
                ushort_t.maxznach = 65535;
                type_data int_t = new type_data();
                int_t.typename = "int";
                int_t.minznach = -2147483648;
                int_t.maxznach = 2147483647;
                type_data uint_t = new type_data();
                uint_t.typename = "uint";
                uint_t.minznach = 0;
                uint_t.maxznach = 4294927295;
                type_data long_t = new type_data();
                long_t.typename = "long_t";
                long_t.minznach = -9223372036854775808;
                long_t.maxznach = 9223372036854775807;
                type_data ulong_t = new type_data();
                ulong_t.typename = "byte";
                ulong_t.minznach = 0;
                ulong_t.maxznach = 18446744073709551615;
                Console.WriteLine(byte_t.Print());
                Console.WriteLine(sbyte_t.Print());
                Console.WriteLine(short_t.Print());
                Console.WriteLine(ushort_t.Print());
                Console.WriteLine(int_t.Print());
                Console.WriteLine(uint_t.Print());
                Console.WriteLine(long_t.Print());
                Console.WriteLine(ulong_t.Print());
                Console.WriteLine("Для перехода к следующему решению нажмите enter");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Задание 3\r\nПрограмма примимает данные пользователя и выводит из в необходимом порядке ");
                personal_data user1 = new personal_data();
                Console.WriteLine("Введите ваше имя");
                user1.name = Console.ReadLine();
                Console.WriteLine("Введите ваш возраст");
                user1.age = Console.ReadLine();
                Console.WriteLine("Введите ваш город");
                user1.city = Console.ReadLine();
                Console.WriteLine("Создайте PIN");
                user1.PIN = Console.ReadLine();
                Console.WriteLine(user1.Print());
                Console.WriteLine("Для перехода к следующему решению нажмите enter");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Задание 4\r\nПрограмма принимает два слова и выдает первые их первые буквы");
                Console.WriteLine("Введите, то что надо");
                string fullname = Console.ReadLine();
                string abbreviated = "";
                char k = ' ';
                for (int i = 0; i < fullname.Length; i += 1)
                {
                    if (i == 0)
                    {
                        abbreviated = fullname[0].ToString();
                        abbreviated += ".";
                    }
                    else if (fullname[i] == k)
                    {
                        abbreviated += fullname[i + 1].ToString();

                    }
                }
                Console.WriteLine(abbreviated);
                Console.WriteLine("Для перехода к следующему решению нажмите enter");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Задание 5\r\nПрограмма расчитывает какое количество товара необходимо продать чтобы выгода позволлина съездить в отпуск\r\nВсе значения вводятся пользователем");
                vacation firsttest = new vacation();
                int n = 0;
                Console.WriteLine("Введите стандартную цену за единицу товара");
                firsttest.normPrice = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите скидку на единицу товара");
                firsttest.salePrice = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите цену отпуска");
                firsttest.holidayPrice = int.Parse(Console.ReadLine());
                for (int i = 0; firsttest.holidayPrice > 0; i++)
                {
                    firsttest.holidayPrice -= firsttest.Print();
                    n += 1;
                }
                Console.WriteLine("Необходимо продать " + n + " единиц товара");
                Console.WriteLine("Для перехода к следующему решению нажмите enter");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Задание 6\r\nПрограмма принимает скорость в км/ч и переводит в см/сек, округляя в меньшую сторону до целого числа");
                Console.WriteLine("Введите значение скорости");
                double V = double.Parse(Console.ReadLine());
                Console.WriteLine("В см/сек скорость равна " + Math.Floor(V * 100000 / 3600));
                Console.WriteLine("Для перехода к следующему решению нажмите enter");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Задание 7\r\nПрограмма изменяет регистр всех букв латинского алфавита на противоположный");
                Console.WriteLine("Напишите что-нибудь");
                string str = Console.ReadLine();
                string str2 = "";
                for (int i = 0; i < str.Length; i++)
                {
                    if (Convert.ToInt16(str[i]) <= 90)
                    {
                        str2 += Convert.ToChar(Convert.ToInt16(str[i]) + 32);
                    }
                    else
                    {
                        str2 += Convert.ToChar(Convert.ToInt16(str[i]) - 32);
                    }
                }
                Console.WriteLine(str2);
                Console.WriteLine("Для заветшения нажмите enter");
                Console.ReadKey();
            }
        }
    }
}