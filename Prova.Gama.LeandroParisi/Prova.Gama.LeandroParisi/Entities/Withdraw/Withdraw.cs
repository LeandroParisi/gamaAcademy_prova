using System;
using System.Collections.Generic;
using System.Text;

namespace Prova.Gama.LeandroParisi.Interfaces
{
    public class Withdraw
    {
        public int Value { get; private set; }
        public DateTime Date { get; private set; }

        public Withdraw(int value)
        {
            Value = value;
            Date = DateTime.Now;
        }
    }
}
