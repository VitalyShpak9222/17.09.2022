using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST_app
{
    class Program
    {
   
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            for (int i = 0; i < str.Length ; i++)
            {
                if (Convert.ToInt16(str[i]) <= 90)
                {
                    str[i] = str[i].Replace(str[i], Convert.ToChar(Convert.ToInt16(str[i]) + 32));
                }
            }
            Console.WriteLine(Convert.ToInt16(n));
            Console.ReadKey();
        }
    }
}
