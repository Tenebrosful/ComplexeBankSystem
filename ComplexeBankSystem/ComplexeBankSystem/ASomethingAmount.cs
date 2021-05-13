using System;

namespace ComplexeBankSystem
{
    abstract class ASomethingAmount
    {
        #region Properties
        public double Amount { get; protected set; }
        #endregion

        public double Add(double amount)
        {
            if (amount <= 0) throw new ArgumentException("Doit être supérieur ou égal à 0", nameof(amount));

            return Amount += amount;
        }

        public double Remove(double amount)
        {
            if (amount >= 0) throw new ArgumentException("Doit être supérieur ou égal à 0", nameof(amount));
            if (amount > Amount) throw new NotEnoughException(amount, Amount);

            return Amount -= amount;
        }

        /// <summary>
        /// Add if amount is positive or substract if amount is negative
        /// </summary>
        /// <param name="amount"></param>
        /// <exception cref="NotEnoughException">Throw if amount is negative and Amount is lower than amount</exception>
        /// <returns>New value of Amount</returns>
        public double Transaction(double amount)
        {
            if (amount < 0 && Math.Abs(amount) > Amount) throw new NotEnoughException(amount, Amount);

            return Amount += amount;
        }
    }
}
