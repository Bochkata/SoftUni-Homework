using System;
using System.Collections.Generic;


namespace T06MoneyTransactions
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] stringElements = Console.ReadLine().Split(new[] { '-', ',' }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<int, double> bankAccountsAndBalances = new Dictionary<int, double>();

            for (int i = 0; i < stringElements.Length - 1; i += 2)
            {
                bankAccountsAndBalances.Add(int.Parse(stringElements[i]), double.Parse(stringElements[i + 1]));
            }

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string subCommand = tokens[0];
                string bankAccount = tokens[1];
                string sum = tokens[2];

                try
                {
                    if (subCommand != "Deposit" && subCommand != "Withdraw")
                    {
                        Console.WriteLine("Invalid command!");
                        continue;
                    }

                    if (int.TryParse(bankAccount, out int account) == false)
                    {
                        throw new FormatException();
                    }

                    int bankAcc = int.Parse(bankAccount);
                    if (double.TryParse(sum, out double bankSum) == false)
                    {
                        throw new FormatException();
                    }

                    double sumToDepositOrWithDraw = double.Parse(sum);

                    if (!bankAccountsAndBalances.ContainsKey(bankAcc))
                    {
                        throw new FormatException();
                    }

                    if (subCommand == "Deposit")
                    {
                        bankAccountsAndBalances[bankAcc] += sumToDepositOrWithDraw;
                    }
                    else if (subCommand == "Withdraw")
                    {
                        if (bankAccountsAndBalances[bankAcc] < sumToDepositOrWithDraw)
                        {
                            Console.WriteLine("Insufficient balance!");
                            continue;
                        }
                        else
                        {
                            bankAccountsAndBalances[bankAcc] -= sumToDepositOrWithDraw;
                        }

                    }

                    Console.WriteLine($"Account {bankAcc} has new balance: {bankAccountsAndBalances[bankAcc]:f2}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid account!");
                }
                finally
                {
                    Console.WriteLine("Enter another command");
                }
            }

        }
    }
}
