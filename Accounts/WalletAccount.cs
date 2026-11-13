using WalletSystem.Transactions;

namespace WalletSystem.Accounts;

public class WalletAccount(decimal startingBalance)
{
    public decimal Balance { get; private set; } = startingBalance;

    public void Apply(WalletTransaction transaction)
    {
        Balance = transaction switch
        {
            Topup topup => Balance + topup.Amount,
            Purchase purchase => Balance - purchase.Amount,
            Withdrawal withdrawal => Balance - withdrawal.Amount,
            Refund refund => Balance + refund.Amount,
        };
    }
}
