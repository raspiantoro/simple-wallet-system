using System;

namespace WalletSystem.Transactions;

/// <summary>Money returned to the wallet for an earlier purchase.</summary>
public class Refund(Guid purchaseId, string merchantName, decimal amount)
{
    public Guid PurchaseId { get; } = purchaseId;
    public string MerchantName { get; } = merchantName;
    public decimal Amount { get; } = amount;
}
