using Prova.Gama.LeandroParisi.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prova.Gama.LeandroParisi.Interfaces
{
    public interface IAutomaticMachine
    {
        public List<BankNote> Withdrawn(int withdrawnValue, Account account);

        public List<BankNote> CountNotes(int withdrawnValue);
    }
}
