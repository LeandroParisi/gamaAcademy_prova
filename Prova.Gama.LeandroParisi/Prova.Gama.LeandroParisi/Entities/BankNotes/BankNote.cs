using System;
using System.Collections.Generic;
using System.Text;

namespace Prova.Gama.LeandroParisi.AbstractClasses
{
    public class BankNote
    {
        public int Value { get; private set; }

        public BankNote(int value)
        {
            Value = value;
        }
    }
}
