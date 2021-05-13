using ComplexeBankSystem.Accounts.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexeBankSystem.Accounts
{
    class AccountFormula
    {
        #region Properties
        public string Name { get; private set; }
        public double MinimalInitialAmount { get; private set; }
        public AccountType AccountType { get; private set; }
        #endregion

        public AccountFormula(string name, double minimalInitialAmount, AccountType accountType)
        {
            Name = name; MinimalInitialAmount = minimalInitialAmount; AccountType = accountType;
        }
    }
}
