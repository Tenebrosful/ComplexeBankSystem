using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComplexeBankSystem.Accounts.Enums;

namespace ComplexeBankSystem.Accounts
{
    class StandardAccount : AAccount
    {
        public StandardAccount(string name, double initialAmount) : base(name, initialAmount, AccountType.Standard)
        {
        }
    }
}
