using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class BankAccountBase<T>
    {
        private T accountNumber { get; set; }
        private double balance { get; set; }
        private string ownerFullName { get; set; }

        public void InPut()
        {
            Console.WriteLine("Введите номер счета:");
            accountNumber = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
            Console.WriteLine("Введите баланс счета:");
            balance = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ФИО владельца счета:");
            ownerFullName = Console.ReadLine();
        }

        public string GetInfo()
        {
            return $"Account Number:{accountNumber}\nBalance:{balance}\nOwner Full Name:{ownerFullName}";
        }
    }
}
