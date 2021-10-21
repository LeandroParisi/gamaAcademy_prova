using System;
using System.Collections.Generic;
using System.Text;

namespace Prova.Gama.LeandroParisi.Interfaces
{
    public interface IAccount
    {
        void AddWithdraw(Withdraw withdraw);

        void Withdraw(int value);

        void Deposit(int value);
    }
}
