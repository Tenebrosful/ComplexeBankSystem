using System;
using System.Collections.Generic;

namespace ComplexeBankSystem
{
    class Bank
    {
        #region Properties
        private static readonly List<Bank> _banks = new();
        private readonly Dictionary<Player, Account> _clients;
        private readonly List<Player> _owners;

        public static IReadOnlyList<Bank> Banks => _banks;
        public IReadOnlyDictionary<Player, Account> Clients => _clients;
        public IReadOnlyList<Player> Owners => _owners;

        public string Name { get; private set; }
        
        /// <summary>
        /// Argent réel que la Banque possède (L'argent maximum que les clients peuvent récupérer s'ils retirent tous leur argent en même temps)
        /// </summary>
        public double BankMoney { get; private set; }

        /// <summary>
        /// Sommme de l'argent présent sur tous les comptes de la banque
        /// </summary>
        public double TotalAccountMoney { get; private set; }
        #endregion

        public Bank(string name, List<Player> owners)
        {
            Name = name; _owners = owners; _clients = new Dictionary<Player, Account>();
        }

        public void NewClient(Player client)
        {
            if (client == null) throw new ArgumentNullException(nameof(client));

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
