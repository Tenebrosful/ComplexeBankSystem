using System;
using ComplexeBankSystem.Accounts.Enums;

namespace ComplexeBankSystem.Accounts
{
    abstract class AAccount : ASomethingAmount
    {
        public string Name { get; private set; }
        public AccountType AccountType { get; private set; }

        public AAccount(string name, double initialAmount, AccountType accountType)
        {
            if (initialAmount <= 0) throw new ArgumentException("Doit être strictement supérieur");

            Name = name;
            Amount = initialAmount;
            AccountType = accountType;
        }
    }
}