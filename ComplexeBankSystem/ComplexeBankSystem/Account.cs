using System;

namespace ComplexeBankSystem
{
    internal class Account : ASomethingAmount
    {
        public string Name { get; private set; }

        public Account(string name, double initialAmount)
        {
            if (initialAmount <= 0) throw new ArgumentException("Doit être strictement supérieur");

            Name = name;
            Amount = initialAmount;
        }
    }
}