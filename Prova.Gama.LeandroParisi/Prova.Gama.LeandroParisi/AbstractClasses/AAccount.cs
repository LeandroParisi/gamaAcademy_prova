using Prova.Gama.LeandroParisi.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prova.Gama.LeandroParisi.AbstractClasses
{
    public abstract class Account : IAccount
    {
        public int TotalBalance { get; private set; }
        public List<Withdraw> Withdraws { get; private set; }
        public int Tax { get; private set; }

        public Account(int tax)
        {
            Tax = tax;
            Withdraws = new List<Withdraw>();
        }

        public void AddWithdraw(Withdraw withdraw)
        {
            Withdraws.Add(withdraw);
        }

        public void Withdraw(int value)
        {
            TotalBalance -= value;
        }

        public void Deposit(int value)
        {
            TotalBalance += value;
        }
    }
}
