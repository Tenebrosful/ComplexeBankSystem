using System;

namespace ComplexeBankSystem
{
    class Player
    {
        #region Properties
        public double Money { get; private set; }
        #endregion

        public double AddMoney(double amount)
        {
            if (amount <= 0) throw new ArgumentException("Doit être supérieur ou égal à 0", nameof(amount));

            return Money += amount;
        }

        public double RemoveMoney(double amount)
        {
            if (amount >= 0) throw new ArgumentException("Doit être supérieur ou égal à 0", nameof(amount));
            if (amount > Money) throw new NotEnoughException(amount, Money);

            return Money -= amount;
        }

        /// <summary>
        /// Add money if amount is positive or substract money if amount is negative
        /// </summary>
        /// <param name="amount"></param>
        /// <exception cref="NotEnoughException">Throw if amount is negative and Amount is lower than the player have money on him</exception>
        /// <returns>New value of the money that the player have on him</returns>
        public double ChangeMoney(double amount)
        {
            if (amount < 0 && Math.Abs(amount) > Money) throw new NotEnoughException(amount, Money);

            return Money += amount;
        }
    }
}
