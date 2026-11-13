using System;

namespace WalletSystem.Transactions;

/// <summary>Money moved out of the wallet to the owner's bank account.</summary>
public class Withdrawal(string bankAccountNumber, decimal amount)
{
    public string BankAccountNumber { get; } = bankAccountNumber;
    public decimal Amount { get; } = amount;
}
