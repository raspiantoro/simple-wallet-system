using System;

namespace WalletSystem.Transactions;

/// <summary>Money added to the wallet from an external payment method.</summary>
public class Topup(string paymentMethod, decimal amount)
{
    public string PaymentMethod { get; } = paymentMethod;
    public decimal Amount { get; } = amount;
}
