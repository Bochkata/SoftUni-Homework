
using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;


namespace Chainblock
{
    public class ChainblockTest
    {
        private IChainblock chainblock;
        [SetUp]
        public void Setup()
        {
            chainblock = new Chainblock();
        }

        [Test]
        public void AddOnlyUniqueTransactions()
        {

            ITransaction transaction = new Transaction(12456, TransactionStatus.Successfull, "Pesho", "Gosho", 50);

            ITransaction sameIDTransaction =
                new Transaction(12456, TransactionStatus.Successfull, "Stoyan", "Gosho", 34);

            chainblock.Add(transaction);
            chainblock.Add(sameIDTransaction);
            Assert.IsTrue(chainblock.Contains(transaction));
            Assert.AreEqual(1, chainblock.Count);

        }
        [Test]
        public void ContainsOnlyTransactionsWithUniqueID()
        {

            ITransaction transaction = new Transaction(12456, TransactionStatus.Successfull, "Pesho", "Gosho", 50);

            ITransaction sameIDTransaction =
                new Transaction(12456, TransactionStatus.Successfull, "Stoyan", "Gosho", 34);

            chainblock.Add(transaction);
            chainblock.Add(sameIDTransaction);

            Assert.AreEqual(1, chainblock.Count);

        }
        [Test]
        public void CheckContainsUniqueIDMethod()
        {

            ITransaction transaction = new Transaction(12456, TransactionStatus.Successfull, "Pesho", "Gosho", 50);

            ITransaction anotherTransaction =
                new Transaction(22568, TransactionStatus.Successfull, "Stoyan", "Gosho", 34);

            chainblock.Add(transaction);
           
            Assert.AreEqual(true, chainblock.Contains(transaction));
            Assert.AreEqual(true, chainblock.Contains(transaction.Id));
            Assert.IsFalse(chainblock.Contains(anotherTransaction));
            Assert.IsFalse(chainblock.Contains(anotherTransaction.Id));

        }
        [Test]
        public void ExceptionWhenTransactionWIthThatIDNotFoundToChangeStatus()
        {
            ITransaction transaction = new Transaction(12456, TransactionStatus.Successfull, "Pesho", "Gosho", 50);

            ITransaction anotherTransaction =
                new Transaction(22568, TransactionStatus.Successfull, "Stoyan", "Gosho", 34);

            chainblock.Add(transaction);
            chainblock.Add(anotherTransaction);

            Assert.Throws<ArgumentException>(() =>
                chainblock.ChangeTransactionStatus(12, TransactionStatus.Failed));
        }
        [Test]
        public void ChangeTransactionStatusOfTransactionWithExistingID()
        {
            ITransaction transaction = new Transaction(12456, TransactionStatus.Successfull, "Pesho", "Gosho", 50);

            ITransaction anotherTransaction =
                new Transaction(22568, TransactionStatus.Successfull, "Stoyan", "Gosho", 34);

            chainblock.Add(transaction);
            chainblock.Add(anotherTransaction);

            chainblock.ChangeTransactionStatus(12456, TransactionStatus.Failed);
            Assert.AreEqual(TransactionStatus.Failed, transaction.Status);

        }
        [Test]
        public void ExceptionWhileRemovingWhenTransactionWithThatIDNotFound()
        {
            ITransaction transaction = new Transaction(12456, TransactionStatus.Successfull, "Pesho", "Gosho", 50);

            ITransaction anotherTransaction =
                new Transaction(22568, TransactionStatus.Successfull, "Stoyan", "Gosho", 34);

            chainblock.Add(transaction);
            chainblock.Add(anotherTransaction);

            Assert.Throws<InvalidOperationException>(() =>
                chainblock.RemoveTransactionById(22555));
        }
        [Test]
        public void RemovingWhenTransactionWithThatIDExists()
        {
            ITransaction transaction = new Transaction(12456, TransactionStatus.Successfull, "Pesho", "Gosho", 50);

            ITransaction anotherTransaction =
                new Transaction(22568, TransactionStatus.Successfull, "Stoyan", "Gosho", 34);

            chainblock.Add(transaction);
            chainblock.Add(anotherTransaction);

            chainblock.RemoveTransactionById(12456);
            Assert.IsFalse(chainblock.Contains(transaction));
        }
        [Test]
        public void ExceptionWhenGettingTransactionsByNonExistingID()
        {
            ITransaction transaction = new Transaction(12456, TransactionStatus.Successfull, "Pesho", "Gosho", 50);

            ITransaction anotherTransaction =
                new Transaction(22568, TransactionStatus.Successfull, "Stoyan", "Gosho", 34);

            chainblock.Add(transaction);
            chainblock.Add(anotherTransaction);

            Assert.Throws<InvalidOperationException>(() =>
                chainblock.GetById(22555));
        }
        [Test]
        public void GettingTransactionByID()
        {
            ITransaction transaction = new Transaction(12456, TransactionStatus.Successfull, "Pesho", "Gosho", 50);

            ITransaction anotherTransaction =
                new Transaction(22568, TransactionStatus.Successfull, "Stoyan", "Gosho", 34);

            chainblock.Add(transaction);
            chainblock.Add(anotherTransaction);

            Assert.AreEqual(transaction, chainblock.GetById(12456));
        }
        
        [Test]
        public void Exception_WhenNoTransactionsWithRequiredStatus()
        {
            for (int i = 0; i < 10; i++)
            {
               
                if (i% 2 == 0)
                {
                    chainblock.Add(new Transaction(11+i, TransactionStatus.Failed, "Stoyan", "aaa", 10));
                }
                else if (i % 3 == 0)
                {
                    chainblock.Add(new Transaction(11 + i, TransactionStatus.Unauthorized, "Stoyan", "aaa", 10));
                }
                else
                {
                    chainblock.Add(new Transaction(11 + i, TransactionStatus.Successfull, "Pesho", "Gosho", 20));
                }
                
            }
            Assert.Throws<InvalidOperationException>(() => chainblock.GetByTransactionStatus(TransactionStatus.Aborted));
        }
        [Test]
        public void GetTransactionsWithRequiredExistingStatus()
        {
            for (int i = 0; i < 10; i++)
            {

                if (i % 2 == 0)
                {
                    chainblock.Add(new Transaction(11 + i, TransactionStatus.Failed, "Stoyan", "aaa", 10));
                }
                else if (i % 3 == 0)
                {
                    chainblock.Add(new Transaction(11 + i, TransactionStatus.Unauthorized, "Stoyan", "aaa", 10));
                }
                else
                {
                    chainblock.Add(new Transaction(11 + i, TransactionStatus.Successfull, "Pesho", "Gosho", 20));
                }

            }

            List<ITransaction> filteredTransactions_expected = chainblock.Where(x => x.Status == TransactionStatus.Successfull)
                .OrderByDescending(x => x.Amount).ToList();
            CollectionAssert.AreEqual(filteredTransactions_expected, chainblock.GetByTransactionStatus(TransactionStatus.Successfull));
        }
        [Test]
        public void Exception_WhenHaveToReturnSendersAndNoTransactionsWithRequiredStatus()
        {
            for (int i = 0; i < 10; i++)
            {

                if (i % 2 == 0)
                {
                    chainblock.Add(new Transaction(11 + i, TransactionStatus.Failed, "Stoyan", "aaa", 10));
                }
                else if (i % 3 == 0)
                {
                    chainblock.Add(new Transaction(11 + i, TransactionStatus.Unauthorized, "Stoyan", "aaa", 10));
                }
                else
                {
                    chainblock.Add(new Transaction(11 + i, TransactionStatus.Successfull, "Pesho", "Gosho", 20));
                }

            }
            Assert.Throws<InvalidOperationException>(() => chainblock.GetAllSendersWithTransactionStatus(TransactionStatus.Aborted));
        }
        [Test]
        public void GetListOfAllSendersWithTransactionsWithRequiredExistingStatus()
        {
            for (int i = 0; i < 10; i++)
            {

                if (i % 2 == 0)
                {
                    chainblock.Add(new Transaction(11 + i, TransactionStatus.Failed, "Stoyan", "aaa", 10));
                }
                else if (i % 3 == 0)
                {
                    chainblock.Add(new Transaction(11 + i, TransactionStatus.Unauthorized, "Stoyan", "aaa", 10));
                }
                else
                {
                    chainblock.Add(new Transaction(11 + i, TransactionStatus.Successfull, "Pesho", "Gosho", 20));
                }

            }

            List<string> filteredTransactions_expected = chainblock.Where(x => x.Status == TransactionStatus.Successfull)
                .OrderBy(x => x.Amount).Select(x=>x.From).ToList();
            CollectionAssert.AreEqual(filteredTransactions_expected, chainblock.GetAllSendersWithTransactionStatus(TransactionStatus.Successfull));
        }
        [Test]
        public void Exception_WhenHaveToReturnReceiversAndNoTransactionsWithRequiredStatus()
        {
            for (int i = 0; i < 10; i++)
            {

                if (i % 2 == 0)
                {
                    chainblock.Add(new Transaction(11 + i, TransactionStatus.Failed, "Stoyan", "aaa", 10));
                }
                else if (i % 3 == 0)
                {
                    chainblock.Add(new Transaction(11 + i, TransactionStatus.Unauthorized, "Stoyan", "aaa", 10));
                }
                else
                {
                    chainblock.Add(new Transaction(11 + i, TransactionStatus.Successfull, "Pesho", "Gosho", 20));
                }

            }
            Assert.Throws<InvalidOperationException>(() => chainblock.GetAllReceiversWithTransactionStatus(TransactionStatus.Aborted));
        }
        [Test]
        public void GetListOfAllReceiversWithTransactionsWithRequiredExistingStatus()
        {
            for (int i = 0; i < 10; i++)
            {

                if (i % 2 == 0)
                {
                    chainblock.Add(new Transaction(11 + i, TransactionStatus.Failed, "Stoyan", "aaa", 10));
                }
                else if (i % 3 == 0)
                {
                    chainblock.Add(new Transaction(11 + i, TransactionStatus.Unauthorized, "Stoyan", "aaa", 10));
                }
                else
                {
                    chainblock.Add(new Transaction(11 + i, TransactionStatus.Successfull, "Pesho", "Gosho", 20));
                }

            }

            List<string> filteredTransactions_expected = chainblock.Where(x => x.Status == TransactionStatus.Successfull)
                .OrderBy(x => x.Amount).Select(x => x.To).ToList();
            CollectionAssert.AreEqual(filteredTransactions_expected, chainblock.GetAllReceiversWithTransactionStatus(TransactionStatus.Successfull));
        }

        [Test]
        public void CheckMethodToReturnAllTransactionsOrderedDescendingByAmountAndTHEnByID()
        {
            for (int i = 0; i < 10; i++)
            {

                if (i % 2 == 0)
                {
                    chainblock.Add(new Transaction(11 + i, TransactionStatus.Failed, "Stoyan", "aaa", 10));
                }
                else if (i % 3 == 0)
                {
                    chainblock.Add(new Transaction(11 + i, TransactionStatus.Unauthorized, "Stoyan", "aaa", 10));
                }
                else
                {
                    chainblock.Add(new Transaction(11 + i, TransactionStatus.Successfull, "Pesho", "Gosho", 20));
                }

            }

            List<ITransaction> expected = chainblock.OrderByDescending(x => x.Amount).ThenBy(x => x.Id).ToList();
            CollectionAssert.AreEqual(expected, chainblock.GetAllOrderedByAmountDescendingThenById());
        }
        [Test]
        public void Exception_GetBySenderOrderedByAmountDescendingWhenNoSuchSenderExists()
        {
            for (int i = 0; i < 10; i++)
            {

                if (i % 2 == 0)
                {
                    chainblock.Add(new Transaction(11 + i, TransactionStatus.Failed, "Stoyan", "aaa", 10));
                }
                else if (i % 3 == 0)
                {
                    chainblock.Add(new Transaction(11 + i, TransactionStatus.Unauthorized, "Stoyan", "aaa", 10));
                }
                else
                {
                    chainblock.Add(new Transaction(11 + i, TransactionStatus.Successfull, "Pesho", "Gosho", 20));
                }

            }

            Assert.Throws<InvalidOperationException>(() => chainblock.GetBySenderOrderedByAmountDescending("Misho"));

        }

        [Test]
        public void CheckMethodGetBySenderOrderedByAmountDescendingWhenSuchSenderExists()
       
        {
            for (int i = 0; i < 10; i++)
            {

                if (i % 2 == 0)
                {
                    chainblock.Add(new Transaction(11 + i, TransactionStatus.Failed, "Stoyan", "aaa", 10));
                }
                else if (i % 3 == 0)
                {
                    chainblock.Add(new Transaction(11 + i, TransactionStatus.Unauthorized, "Stoyan", "aaa", 10));
                }
                else
                {
                    chainblock.Add(new Transaction(11 + i, TransactionStatus.Successfull, "Pesho", "Gosho", 20));
                }

            }

            List<ITransaction> expected =
                chainblock.Where(x => x.To == "aaa").OrderByDescending(x => x.Amount).ToList();
            CollectionAssert.AreEqual(expected, chainblock.GetBySenderOrderedByAmountDescending("aaa"));
        }
        [Test]
        public void Exception_GetByMethodCheckForUnexistingReceiverOrderedByAmountThenById()
        {
            for (int i = 0; i < 10; i++)
            {

                if (i % 2 == 0)
                {
                    chainblock.Add(new Transaction(11 + i, TransactionStatus.Failed, "Stoyan", "aaa", 10));
                }
                else if (i % 3 == 0)
                {
                    chainblock.Add(new Transaction(11 + i, TransactionStatus.Unauthorized, "Stoyan", "aaa", 10));
                }
                else
                {
                    chainblock.Add(new Transaction(11 + i, TransactionStatus.Successfull, "Pesho", "Gosho", 20));
                }

            }

            Assert.Throws<InvalidOperationException>(() => chainblock.GetByReceiverOrderedByAmountThenById("Misho"));

        }

        [Test]
        public void CheckMethodGetByReceiverOrderedByAmountThenById()

        {
            for (int i = 0; i < 10; i++)
            {

                if (i % 2 == 0)
                {
                    chainblock.Add(new Transaction(11 + i, TransactionStatus.Failed, "Stoyan", "aaa", 10));
                }
                else if (i % 3 == 0)
                {
                    chainblock.Add(new Transaction(11 + i, TransactionStatus.Unauthorized, "Stoyan", "aaa", 10));
                }
                else
                {
                    chainblock.Add(new Transaction(11 + i, TransactionStatus.Successfull, "Pesho", "Gosho", 20));
                }

            }

            List<ITransaction> expected =
                chainblock.Where(x => x.To == "aaa").OrderByDescending(x => x.Amount).ThenBy(x=>x.Id).ToList();
            CollectionAssert.AreEqual(expected, chainblock.GetByReceiverOrderedByAmountThenById("aaa"));
        }

        [Test]
        public void CheckMethodGetByTransactionStatusAndMaximumAmount()

        {
            for (int i = 0; i < 10; i++)
            {

                if (i % 2 == 0)
                {
                    chainblock.Add(new Transaction(11 + i, TransactionStatus.Failed, "Stoyan", "aaa", 10));
                }
                else if (i % 3 == 0)
                {
                    chainblock.Add(new Transaction(11 + i, TransactionStatus.Unauthorized, "Stoyan", "aaa", 20));
                }
                else
                {
                    chainblock.Add(new Transaction(11 + i, TransactionStatus.Successfull, "Pesho", "Gosho", 20));
                }

            }

            double maxAmount = 20;
            TransactionStatus transactionStatus = TransactionStatus.Successfull;
            List<ITransaction> expected = chainblock.Where(x => x.Amount <= maxAmount)
                .Where(x => x.Status == transactionStatus).OrderByDescending(x => x.Amount).ToList();
            CollectionAssert.AreEqual(expected, chainblock.GetByTransactionStatusAndMaximumAmount(transactionStatus, maxAmount));
        }
        [Test]
        public void Exception_GetBySenderAndMinimumAmountDescending()
        {
            for (int i = 0; i < 10; i++)
            {

                if (i % 2 == 0)
                {
                    chainblock.Add(new Transaction(11 + i, TransactionStatus.Failed, "Stoyan", "aaa", 10));
                }
                else if (i % 3 == 0)
                {
                    chainblock.Add(new Transaction(11 + i, TransactionStatus.Unauthorized, "Stoyan", "aaa", 10));
                }
                else
                {
                    chainblock.Add(new Transaction(11 + i, TransactionStatus.Successfull, "Pesho", "Gosho", 20));
                }

            }

            Assert.Throws<InvalidOperationException>(() => chainblock.GetBySenderAndMinimumAmountDescending("Misho", 5));

        }

        [Test]
        public void CheckMethodGetBySenderAndMinimumAmountDescending()

        {
            for (int i = 0; i < 10; i++)
            {

                if (i % 2 == 0)
                {
                    chainblock.Add(new Transaction(11 + i, TransactionStatus.Failed, "Stoyan", "aaa", 10));
                }
                else if (i % 3 == 0)
                {
                    chainblock.Add(new Transaction(11 + i, TransactionStatus.Unauthorized, "Stoyan", "aaa", 10));
                }
                else
                {
                    chainblock.Add(new Transaction(11 + i, TransactionStatus.Successfull, "Pesho", "Gosho", 20));
                }

            }

            List<ITransaction> expected =
                chainblock.Where(x => x.From == "Pesho").Where(x => x.Amount > 10).OrderByDescending(x => x.Amount)
                    .ToList();
            CollectionAssert.AreEqual(expected, chainblock.GetBySenderAndMinimumAmountDescending("Pesho", 10));
        }
        [Test]
        public void Exception_GetByReceiverAndAmountRange()
        {
            for (int i = 0; i < 10; i++)
            {

                if (i % 2 == 0)
                {
                    chainblock.Add(new Transaction(11 + i, TransactionStatus.Failed, "Stoyan", "aaa", 10));
                }
                else if (i % 3 == 0)
                {
                    chainblock.Add(new Transaction(11 + i, TransactionStatus.Unauthorized, "Stoyan", "aaa", 10));
                }
                else
                {
                    chainblock.Add(new Transaction(11 + i, TransactionStatus.Successfull, "Pesho", "Gosho", 20));
                }

            }

            Assert.Throws<InvalidOperationException>(() => chainblock.GetByReceiverAndAmountRange("Misho", 5, 15));

        }

        [Test]
        public void CheckMethodGetByReceiverAndAmountRange()

        {
            for (int i = 0; i < 10; i++)
            {

                if (i % 2 == 0)
                {
                    chainblock.Add(new Transaction(11 + i, TransactionStatus.Failed, "Stoyan", "aaa", 10));
                }
                else if (i % 3 == 0)
                {
                    chainblock.Add(new Transaction(11 + i, TransactionStatus.Unauthorized, "Stoyan", "aaa", 10));
                }
                else
                {
                    chainblock.Add(new Transaction(11 + i, TransactionStatus.Successfull, "Pesho", "Gosho", 20));
                }

            }

            List<ITransaction> expected =
                chainblock.Where(x => x.To == "aaa").Where(x => x.Amount >= 10 && x.Amount < 15)
                    .OrderByDescending(x => x.Amount).ThenBy(x => x.Id).ToList();
            CollectionAssert.AreEqual(expected, chainblock.GetByReceiverAndAmountRange("aaa", 10, 15));
        }
        [Test]
        public void GetAllInAmountRange()

        {
            for (int i = 0; i < 10; i++)
            {

                if (i % 2 == 0)
                {
                    chainblock.Add(new Transaction(11 + i, TransactionStatus.Failed, "Stoyan", "aaa", 10));
                }
                else if (i % 3 == 0)
                {
                    chainblock.Add(new Transaction(11 + i, TransactionStatus.Unauthorized, "Stoyan", "aaa", 10));
                }
                else
                {
                    chainblock.Add(new Transaction(11 + i, TransactionStatus.Successfull, "Pesho", "Gosho", 20));
                }

            }

            List<ITransaction> expected = chainblock.Where(x => x.Amount >= 10 && x.Amount <= 20).ToList();
            CollectionAssert.AreEqual(expected, chainblock.GetAllInAmountRange(10,20));
        }

    }
}