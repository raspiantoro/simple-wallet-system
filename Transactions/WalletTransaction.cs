namespace WalletSystem.Transactions;

public readonly union WalletTransaction(Topup, Withdrawal, Purchase, Refund);
