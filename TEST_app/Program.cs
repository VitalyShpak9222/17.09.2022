using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST_app
{

    public enum AccountType
    {
        Main,
        Deposit,
        Credit
    }

    public struct Account
    {
        public Guid Id { get; set; }
        public long Number { get; set; }
        public AccountType Type { get; set; }
        public decimal Total { get; set; }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Account test = new Account() { Id = Guid.NewGuid(), Number = 49751234095, Type = AccountType.Deposit, Total = 2412 };

            Console.WriteLine($"Id - {test.Id};\nNumber - {test.Number};\nType - {test.Type};\nTotal - {test.Total};");
            Console.ReadKey();
        }
    }
}
