using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;



namespace Chainblock
{
    public class Chainblock : IChainblock
    {
        private readonly Dictionary<int, ITransaction> transactions;
        public Chainblock()
        {
            transactions = new Dictionary<int, ITransaction>();
        }


        public int Count => transactions.Count;
        public void Add(ITransaction tx)
        {
            if (!transactions.ContainsKey(tx.Id))
            {
                transactions.Add(tx.Id, tx);
            }

        }

        public bool Contains(ITransaction tx)
        {
            return transactions.ContainsKey(tx.Id);
        }

        public bool Contains(int id) => transactions.ContainsKey(id);

        public void ChangeTransactionStatus(int id, TransactionStatus newStatus)
        {
            if (!transactions.ContainsKey(id))
            {
                throw new ArgumentException();
            }

            transactions[id].Status = newStatus;
        }

        public void RemoveTransactionById(int id)
        {
            if (!transactions.ContainsKey(id))
            {
                throw new InvalidOperationException();
            }

            transactions.Remove(id);
        }

        public ITransaction GetById(int id)
        {
            if (!transactions.ContainsKey(id))
            {
                throw new InvalidOperationException();
            }

            return transactions[id];
        }

        public IEnumerable<ITransaction> GetByTransactionStatus(TransactionStatus status)
        {
            if (transactions.All(x=>x.Value.Status != status))
            {
                throw new InvalidOperationException();
            }

            return transactions.Values.Where(x => x.Status == status).OrderByDescending(x => x.Amount);
        }

        public IEnumerable<string> GetAllSendersWithTransactionStatus(TransactionStatus status)
        {
            if (transactions.All(x=>x.Value.Status != status))
            {
                throw new InvalidOperationException();
            }

            return transactions.Values.Where(x => x.Status == status).OrderBy(x => x.Amount).Select(x => x.From);
        }

        public IEnumerable<string> GetAllReceiversWithTransactionStatus(TransactionStatus status)
        {
            if (transactions.All(x => x.Value.Status != status))
            {
                throw new InvalidOperationException();
            }

            return transactions.Values.Where(x => x.Status == status).OrderBy(x => x.Amount).Select(x => x.To);
        }

        public IEnumerable<ITransaction> GetAllOrderedByAmountDescendingThenById()
        {
            return transactions.Values.OrderByDescending(x => x.Amount).ThenBy(x => x.Id);
        }

        public IEnumerable<ITransaction> GetBySenderOrderedByAmountDescending(string sender)
        {
            if (transactions.All(x=>x.Value.To != sender))
            {
                throw new InvalidOperationException();
            }

            return transactions.Values.Where(x => x.To == sender).OrderByDescending(x => x.Amount);
        }

        public IEnumerable<ITransaction> GetByReceiverOrderedByAmountThenById(string receiver)
        {
            if (transactions.All(x=>x.Value.To != receiver))
            {
                throw new InvalidOperationException();
            }

            return transactions.Values.Where(x => x.To == receiver).OrderByDescending(x => x.Amount).ThenBy(x => x.Id);
        }

        public IEnumerable<ITransaction> GetByTransactionStatusAndMaximumAmount(TransactionStatus status, double amount)
        {
            return transactions.Values.Where(x => x.Status == status).Where(x => x.Amount <= amount)
                .OrderByDescending(x => x.Amount);
        }

        public IEnumerable<ITransaction> GetBySenderAndMinimumAmountDescending(string sender, double amount)
        {
            List<ITransaction> result = transactions.Values.Where(x => x.From == sender).Where(x => x.Amount > amount)
                .OrderByDescending(x => x.Amount).ToList();
            if (result.Count == 0)
            {
                throw new InvalidOperationException();
            }

            return result;
        }

        public IEnumerable<ITransaction> GetByReceiverAndAmountRange(string receiver, double lo, double hi)
        {
            List<ITransaction> result = transactions.Values.Where(x => x.To == receiver)
                .Where(x => x.Amount >= lo && x.Amount < hi).OrderByDescending(x => x.Amount).ThenBy(x => x.Id)
                .ToList();
            if (result.Count == 0)
            {
                throw new InvalidOperationException();
            }

            return result;
        }

        public IEnumerable<ITransaction> GetAllInAmountRange(double lo, double hi)
        {
            return transactions.Values.Where(x => x.Amount >= lo && x.Amount <= hi);

        }

        public IEnumerator<ITransaction> GetEnumerator()
        {
            foreach (KeyValuePair<int, ITransaction> transaction in transactions)
            {
                yield return transaction.Value;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
