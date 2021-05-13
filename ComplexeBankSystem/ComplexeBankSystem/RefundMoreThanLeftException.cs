using System;

namespace ComplexeBankSystem
{
    class RefundMoreThanLeftException : ArgumentException
    {
        public double Argument { get; private set; }
        public double Left { get; private set; }

        public RefundMoreThanLeftException(double argument, double left) : base("Tentative de rembourser plus que le montant restant")
        {
            Argument = argument;
            Left = left;
        }
    }
}
