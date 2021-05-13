using System;
using System.Collections.Generic;

namespace ComplexeBankSystem
{
    class Bank
    {
        private static readonly List<Bank> _banks = new List<Bank>();
        public string Name { get; private set; }
        public static IReadOnlyList<Bank> Banks { get; private set; } = _banks;
        private Dictionary<Player, Account> _clients;
        public IReadOnlyDictionary<Player, Account> Clients { get; private set; }
        /// <summary>
        /// Sommme de l'argent présent sur tous les comptes de la banque
        /// </summary>
        public double TotalAccountMoney { get; private set; }
        /// <summary>
        /// Argent réel que la Banque possède (L'argent maximum que les clients peuvent récupérer s'ils retirent tous leur argent en même temps)
        /// </summary>
        public double BankMoney { get; private set; }

        public Bank(string name)
        {
            Name = name; Clients = _clients;
        }

        public void NewClient(Player client)
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (_clients == null) _clients = new Dictionary<Player, Account>();

            try
            {
                _clients.Add(client, null);
            }
            catch (ArgumentException)
            {
                throw new ArgumentException("Client déjà existant", nameof(client));
            }
        }
    }
}
