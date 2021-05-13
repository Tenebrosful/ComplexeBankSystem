using ComplexeBankSystem.Accounts.Enums;
using System;

namespace ComplexeBankSystem.Accounts
{
    abstract class AAccount : ASomethingAmount
    {
        #region Properties
        public string Name { get; private set; }
        public AccountType AccountType { get; private set; }
        #endregion

        public AAccount(string name, double initialAmount, AccountType accountType)
        {
            if (initialAmount <= 0) throw new ArgumentException("Doit être strictement supérieur");

            Name = name;
            Amount = initialAmount;
            AccountType = accountType;
        }
    }
}