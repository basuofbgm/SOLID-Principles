public class BankAccount
{
    public decimal Balance { get; private set; }

    public BankAccount(decimal startingBalance)
    {
        Balance = startingBalance;
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Deposit amount must be positive");
        }
        
        Balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Withdrawal amount must be positive");
        }

        if (Balance - amount < 0)
        {
            throw new InvalidOperationException("Insufficient funds for this withdrawal");
        }

        Balance -= amount;
    }
}

public class BankAccountReport
{
    public void GenerateReport(BankAccount account)
    {
        Console.WriteLine($"Current account balance: {account.Balance}");
    }
}
class Program
{
    static void Main()
    {
        var account = new BankAccount(100); // Starting with $100
        account.Deposit(50); // Depositing $50
        account.Withdraw(30); // Withdrawing $30
        
        var report = new BankAccountReport();
        report.GenerateReport(account); // Should output: Current account balance: 120
    }
}
