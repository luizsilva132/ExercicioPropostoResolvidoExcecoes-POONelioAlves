using System;
using System.Globalization;
using ExercicioFixacaoExcecoes.Entities;
using ExercicioFixacaoExcecoes.Entities.Exceptions;

namespace ExercicioFixacaoExcesoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the account data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string holder = Console.ReadLine();
            Console.Write("Initial balance: ");
            double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Withdraw limit: ");
            double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Account acc = new Account(number, holder, balance, withdrawLimit);

            Console.WriteLine();
            Console.Write("Enter amount for withdraw: ");
            double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            try
            {
                acc.Withdraw(amount);
                Console.WriteLine(acc);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
            
        }
    }
}