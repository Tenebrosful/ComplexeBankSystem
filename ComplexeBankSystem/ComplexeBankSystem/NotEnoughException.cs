using System;

namespace ComplexeBankSystem
{
    class NotEnoughException : ArgumentException
    {
        public double Argument { get; private set; }
        public double Own { get; private set; }

        public NotEnoughException(double argument, double own) : base("Tentative de retirer plus d'argent que possédé")
        {
            Argument = argument;
            Own = own;
        }
    }
}
