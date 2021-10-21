using Prova.Gama.LeandroParisi.AbstractClasses;
using Prova.Gama.LeandroParisi.Factories;
using Prova.Gama.LeandroParisi.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prova.Gama.LeandroParisi.Entities
{
    public class AutomaticMachine : IAutomaticMachine
    {
        private int MinBankNote { get; set; }

        public AutomaticMachine ()
        {
            MinBankNote = 5;
        }

        public List<BankNote> Withdrawn(int withdrawnValue, Account account)
        {
            if (account.TotalBalance < withdrawnValue)
            {
                throw new Exception("Account doesn't have sufficiente funds");
            } 
            else if (withdrawnValue % MinBankNote != 0)
            {
                throw new Exception("Invalid withdraw value");
            }

            var bankNotes = CountNotes(withdrawnValue);
            
            account.Withdraw(withdrawnValue);
            var withdraw = new Withdraw(withdrawnValue);
            account.AddWithdraw(withdraw);

            return bankNotes;
        }

        public List<BankNote> CountNotes(int withdrawnValue)
        {
            var bankNotes = new List<BankNote>();
            int remainingValue = withdrawnValue;

            while (remainingValue != 0)
            {
                var generatedNote = BankNoteFactory.CreateBankNote(remainingValue);
                bankNotes.Add(generatedNote);
                remainingValue -= generatedNote.Value;
            }

            return bankNotes;
        }
    }
}
