namespace WalletSystem.Transactions;

/// <summary>Money spent from the wallet at a merchant.</summary>
public class Purchase(string merchantName, decimal amount)
{
    public string MerchantName { get; } = merchantName;
    public decimal Amount { get; } = amount;
}
