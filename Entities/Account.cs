using System;
using ExercicioFixacaoExcecoes.Entities.Exceptions;
using System.Globalization;

namespace ExercicioFixacaoExcecoes.Entities
{
    internal class Account
    {
        public int Number { get; set; }
        public String Holder { get; set; }
        public Double Balance { get; set; }
        public double WithDrawLimit { get; set; }

        public Account()
        {
        }
        public Account(int number, string holder, double balance, double withDrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withDrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > WithDrawLimit)
            {
                throw new DomainException("The amount exceeds withdraws limit");
            }
            if (amount > Balance)
            {
                throw new DomainException("Not enough balance");
            }

            Balance =- amount;

        }

        public override string ToString()
        {
            return "New balance: "
                + Balance.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
