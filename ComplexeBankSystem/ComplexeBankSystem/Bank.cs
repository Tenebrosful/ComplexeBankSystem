using ComplexeBankSystem.Accounts;
using System;
using System.Collections.Generic;

namespace ComplexeBankSystem
{
    class Bank
    {
        #region Properties
        private static readonly List<Bank> _banks = new();
        private readonly Dictionary<Player, List<AAccount>> _clients;
        private readonly HashSet<Player> _owners;
        private readonly List<AccountFormula> _accountFormulas;

        public static IReadOnlyList<Bank> Banks => _banks;
        public IReadOnlyDictionary<Player, List<AAccount>> Clients => _clients;
        public IReadOnlySet<Player> Owners => _owners;
        public IReadOnlyList<AccountFormula> AccountFormulas => _accountFormulas;

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

        public Bank(string name, HashSet<Player> owners)
        {
            Name = name; _owners = owners; _clients = new(); _accountFormulas = new();
        }

        public void NewClient(Player client, AAccount account)
        {
            if (client == null) throw new ArgumentNullException(nameof(client));

            try
            {
                _clients.Add(client, new List<AAccount>() { account });
            }
            catch (ArgumentException)
            {
                throw new ArgumentException("Client déjà existant", nameof(client));
            }
        }

        public void RemoveClient(Player client) => throw new NotImplementedException();

        public void AddOwner(Player owner)
        {
            if (owner == null) throw new ArgumentNullException(nameof(owner));
            if (!_owners.Add(owner)) throw new ArgumentException("Le joueur est déjà propriétaire", nameof(owner));
        }

        public void RemoveOwner(Player owner)
        {
            if (owner == null) throw new ArgumentNullException(nameof(owner));
            if (!_owners.Contains(owner)) throw new ArgumentException("Le joueur n'est pas propriétaire", nameof(owner));

            double x = (BankMoney - TotalAccountMoney) / _owners.Count;

            if (!isProfitable())
                if (owner.Money < Math.Abs(x)) throw new NotEnoughException(owner.Money, Math.Abs(x));

            if (!_owners.Remove(owner))
            {
                BankMoney += x;
                owner.ChangeMoney(x);
            }
        }

        public bool isProfitable() => BankMoney - TotalAccountMoney > 0;
    }
}
