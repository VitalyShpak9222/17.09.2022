using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KW
{
    class Program
    {
        struct employee
        {
            public string firstname;
            public string academic;
            public string Print()
            {
                return $"Имя: {firstname} университет: {academic}";

            }
        }
        public enum university
        {
            KGU,
            KAI,
            KHTI
        }
        struct bank_inform
        {
            public int number;
            public string type_b;
            public double balance;
            public string Print()
            {
                return $"номер: {number} тип: {type_b} баланс: {balance}";
            }
        }
        public enum bank_ser
        {
            current,
            savings
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 3.1\r\nПрограмма выводит элементы переменной типа перечисления");
            foreach (string s in Enum.GetNames(typeof(bank_ser)))
            {
                Console.WriteLine("{0} счет", s);
            }
            Console.WriteLine("Для продолжения нажмите enter");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Задание 3.2");
            Console.WriteLine("Введите номер, тип, баланс счета ( По очереди через enter)");
            bank_inform num1 = new bank_inform();
            num1.number = int.Parse(Console.ReadLine());
            num1.type_b = Console.ReadLine();
            num1.balance = double.Parse(Console.ReadLine());
            Console.WriteLine(num1.Print());
            Console.WriteLine("Для продолжения нажмите enter");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Задание 3.3\r\nЗадание представляется объединение заданий 1 и 2");
            employee employee1 = new employee();
            employee1.academic =  Convert.ToString(university.KGU);
            employee1.firstname = "Александр Макаров";
            Console.WriteLine(employee1.Print());
            Console.WriteLine("Для завершения нажмите enter");
            Console.ReadKey();
        }
    }
}
