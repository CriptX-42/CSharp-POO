using System;
using System.Collections.Generic;
using System.Text;

namespace SelandoMetodos.Entities
{

    sealed class SavingsAccount : Account
    {
            public double InterestRate { get; set; }

            public SavingsAccount()
            {
            }

            public SavingsAccount(int number, string holder, double balance, double interestRate)
                : base(number, holder, balance)
            {
                InterestRate = interestRate;
            }

            public void UpdateBalance()
            {
                Balance += Balance * InterestRate;
            }

            public override void Withdraw(double amount) //metodo está sendo sobrescrito na subclasse por causa do override
            {
                base.Withdraw(amount);
                Balance -= 4.0;
            }
        }
    }
