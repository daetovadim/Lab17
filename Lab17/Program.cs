using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tBank Accounts");
            
            Account<int> account = new Account<int>();
            account.SetAccNumber(89435);
            account.AccBalance = 13845;
            account.FullName = "Дмитрий Попов";
            account.AccCurrency = "руб";
            Console.Write($"\n Владелец счёта №");
            account.GetAccNumber();
            Console.WriteLine($" - {account.FullName}. Остаток на счёте: {account.AccBalance} {account.AccCurrency}.");

            Account<string> account1 = new Account<string>();
            account1.SetAccNumber("AN20485");
            account1.AccBalance = 6982;
            account1.FullName = "Stan Smith";
            account1.AccCurrency = "usd";
            Console.Write($"\n Owner of account №");
            account1.GetAccNumber();
            Console.WriteLine($" is {account1.FullName}. Account balance: {account1.AccBalance} {account1.AccCurrency}.");

            Console.ReadKey();
        }
    }

    class Account<T>
    {
        T accNumber;
        int accBalance;
        string fullName;
        
        public string AccCurrency { get; set; }

        public void SetAccNumber(T value)
        {
            accNumber = value;
        }
        public void GetAccNumber()
        {
            Console.Write(accNumber);
        }

        public int AccBalance
        {
            set
            {
                accBalance = value;
            }
            get
            {
                return accBalance;
            }
        }
        public string FullName
        {
            set
            {
                fullName = value;
            }
            get
            {
                return fullName;
            }
        }
    }
}
