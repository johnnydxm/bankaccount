class BankAccount
{
    // Properties
    public string AccountNumber { get; init; }
    public string Owner { get; init; }
    public decimal Balance { get; private set; }

    // Constructor
    public BankAccount(string number, string owner, decimal openingBalance)
    {
        AccountNumber = number;
        Owner = owner;
        Balance = openingBalance;
    }

    // Deposit money
    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Deposit must be greater than zero.");
        }

        Balance += amount;
    }

    // Withdraw money
    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Withdrawal must be greater than zero.");
        }

        if (amount > Balance)
        {
            throw new InvalidOperationException("Insufficient funds.");
        }

        Balance -= amount;
    }
}

class Program
{
    static void Main()
    {
        // Create account
        BankAccount account = new BankAccount("ACC001", "Mohamed", 1000m);

        Console.WriteLine("Account Owner: " + account.Owner);
        Console.WriteLine("Opening Balance: $" + account.Balance);

        // Deposit
        account.Deposit(500m);
        Console.WriteLine("After Deposit: $" + account.Balance);

        // Withdraw
        account.Withdraw(200m);
        Console.WriteLine("After Withdrawal: $" + account.Balance);

        // Current balance
        Console.WriteLine("Current Balance: $" + account.Balance);
    }
}
