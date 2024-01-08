using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccountBase<int> bankAccount1 = new BankAccountBase<int>();
            bankAccount1.InPut();
            Console.WriteLine(bankAccount1.GetInfo());

            BankAccountBase<string> bankAccount2 = new BankAccountBase<string>();
            bankAccount2.InPut();
            Console.WriteLine(bankAccount2.GetInfo());

            Console.ReadKey();
        }
    }
}
