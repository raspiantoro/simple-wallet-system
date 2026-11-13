using WalletSystem.Accounts;
using WalletSystem.Transactions;

WalletAccount account = new(100);

account.Apply(new Topup("Bank Transfer", 70));
account.Apply(new Withdrawal("GB82WEST12345698765432", 30));
account.Apply(new Purchase("Corner Coffee", 3m));
account.Apply(new Refund(Guid.Parse("b5a1c2d4-8e3f-4a6b-9c7d-1e2f3a4b5c6d"), "Harbor Hardware", 10m));

Console.WriteLine($"Balance: ${account.Balance}");
