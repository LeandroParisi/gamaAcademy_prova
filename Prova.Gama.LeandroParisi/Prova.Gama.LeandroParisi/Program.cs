using Prova.Gama.LeandroParisi.Entities;
using Prova.Gama.LeandroParisi.Entities.Accounts;
using System;

namespace Prova.Gama.LeandroParisi
{
    class Program
    {
        static void Main(string[] args)
        {
            //SuccessfullyWithdraw();
            TryInvalidWithdrawValue();
            //TryWithdrawingWithInsufficientFunds();

        }

        private static void SuccessfullyWithdraw()
        {
            var account = new CheckingAccount();
            var automaticMachine = new AutomaticMachine();

            Console.WriteLine("--- Deposit 500 dol ---");
            account.Deposit(500);
            Console.WriteLine(account.TotalBalance);

            Console.WriteLine("--- Sacar 300 dol ---");
            try
            {
                var notes = automaticMachine.Withdrawn(285, account);
                Console.WriteLine("--- Notas sacadas ---");
                foreach (var note in notes)
                {
                    Console.WriteLine(note.Value);
                }

                Console.WriteLine("--- Saldo Pós saque ---");
                Console.WriteLine(account.TotalBalance);
            }
            catch (Exception error)
            {
                Console.WriteLine($"Erro: {error.Message}");
            }
        }

        private static void TryInvalidWithdrawValue()
        {
            var account = new CheckingAccount();
            var automaticMachine = new AutomaticMachine();

            Console.WriteLine("--- Deposit 500 dol ---");
            account.Deposit(500);
            Console.WriteLine(account.TotalBalance);

            Console.WriteLine("--- Sacar 212 dol ---");
            try
            {
                var notes = automaticMachine.Withdrawn(212, account);
                Console.WriteLine("--- Notas sacadas ---");
                foreach (var note in notes)
                {
                    Console.WriteLine(note.Value);
                }
                Console.WriteLine(account.TotalBalance);
            }
            catch (Exception error)
            {
                Console.WriteLine($"Erro: {error.Message}");
            }
        }

        private static void TryWithdrawingWithInsufficientFunds()
        {
            var account = new CheckingAccount();
            var automaticMachine = new AutomaticMachine();

            Console.WriteLine("--- Deposit 100 dol ---");
            account.Deposit(100);
            Console.WriteLine(account.TotalBalance);

            Console.WriteLine("--- Sacar 212 dol ---");
            try
            {
                var notes = automaticMachine.Withdrawn(212, account);
                Console.WriteLine("--- Notas sacadas ---");
                foreach (var note in notes)
                {
                    Console.WriteLine(note.Value);
                }
                Console.WriteLine(account.TotalBalance);
            }
            catch (Exception error)
            {
                Console.WriteLine($"Erro: {error.Message}");
            }
        }

    }
}
