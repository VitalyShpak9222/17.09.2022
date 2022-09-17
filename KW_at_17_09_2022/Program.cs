using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KW_at_17_09_2022
{
    class Program
    {
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
            Console.ReadKey();


        }
    }
}
