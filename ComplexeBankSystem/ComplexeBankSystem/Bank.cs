using System;
using System.Collections.Generic;
using ComplexeBankSystem.Accounts;

namespace ComplexeBankSystem
{
    class Bank
    {
        #region Properties
        private static readonly List<Bank> _banks = new();
        private readonly Dictionary<Player, AAccount> _clients;
        private readonly List<Player> _owners;

        public static IReadOnlyList<Bank> Banks => _banks;
        public IReadOnlyDictionary<Player, AAccount> Clients => _clients;
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
            Name = name; _owners = owners; _clients = new Dictionary<Player, AAccount>();
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

        public void RemoveClient(Player client) => throw new NotImplementedException();

        public void AddOwner(Player owner) => throw new NotImplementedException();

        public void RemoveOwner(Player owner) => throw new NotImplementedException();
    }
}
