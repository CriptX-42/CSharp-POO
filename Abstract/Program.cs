using System;
using System.Collections.Generic;
using System.Globalization;

namespace Abstract.Entities
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Account> list = new List<Account>();

            list.Add(new SavingsAccount(1001, "Maria", 600.0, 0.01));
            list.Add(new BusinessAccount(1002, "Bobby", 600.0, 200.0));
            list.Add(new SavingsAccount(1003, "João", 600.0, 0.01));
            list.Add(new BusinessAccount(1004, "Cristofer", 600.0, 400.0));

            double sum = 0;

            foreach(Account acc in list)
            {
                sum += acc.Balance;
            }

            Console.WriteLine("Tatal balance: " + sum.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("-------------------------------------------------");

            foreach (Account acc in list)
            {
                Console.WriteLine("Old balance for account: " + acc.Number
                    + ":" +
                    acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
            Console.WriteLine("-------------------------------------------------");
            //forma polimorfica, para cada conta eu vou descontar 10 reais
            foreach (Account acc in list)
            {
                acc.Withdraw(10.0);
            }
            foreach (Account acc in list)
            {
                Console.WriteLine("Update balance for account: " + acc.Number 
                    + ":" +
                    acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
            Console.ReadLine();
            //Account acc1 = new Account(1001, "Alex", 500.0);
            //Account acc2 = new SavingsAccount(1002, "Anna", 500.0, 0.01);

            //acc1.Withdraw(10.0);
            //acc2.Withdraw(10.0);

            //Console.WriteLine(acc1.Balance);
            //Console.WriteLine(acc2.Balance);
        }
    }
}
