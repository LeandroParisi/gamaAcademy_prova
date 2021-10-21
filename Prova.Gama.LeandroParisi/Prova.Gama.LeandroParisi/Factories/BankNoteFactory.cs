using Prova.Gama.LeandroParisi.AbstractClasses;
using Prova.Gama.LeandroParisi.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prova.Gama.LeandroParisi.Factories
{
    static class BankNoteFactory
    {
        public static BankNote CreateBankNote(int value)
        {
            if (value >= 100)
            {
                return new BankNote(100);
            }
            else if (value >= 50)
            {
                return new BankNote(50);
            }
            else if (value >= 20)
            {
                return new BankNote(20);
            }
            else if (value >= 10)
            {
                return new BankNote(10);

            }
            else if (value >= 5)
            {
                return new BankNote(5);
            }
            else
            {
                throw new Exception("Invalid value for Bank Note Factory");
            }
        }
    }
}
