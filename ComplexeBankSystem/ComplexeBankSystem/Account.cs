namespace ComplexeBankSystem
{
    internal class Account : ASomethingAmount
    {
        public string Name { get; private set; }

        public Account(string name)
        {
            Name = name;
        }
    }
}