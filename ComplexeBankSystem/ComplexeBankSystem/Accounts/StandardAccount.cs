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
