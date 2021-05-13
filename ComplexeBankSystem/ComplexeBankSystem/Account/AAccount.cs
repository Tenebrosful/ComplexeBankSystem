using System;

namespace ComplexeBankSystem
{
    abstract class AAccount : ASomethingAmount
    {
        public string Name { get; private set; }

        public AAccount(string name, double initialAmount)
        {
            if (initialAmount <= 0) throw new ArgumentException("Doit être strictement supérieur");

            Name = name;
            Amount = initialAmount;
        }
    }
}