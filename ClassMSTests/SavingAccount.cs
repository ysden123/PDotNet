namespace ClassMSTests;

// Derived class: SavingsAccount
public class SavingAccount(string accountNumber, decimal initialBalance, decimal interestRate) : ABankAccount(accountNumber, initialBalance)
{
    private readonly decimal interestRate = interestRate;

    // Implementing abstract methods
    public override void Deposit(decimal amount)
    {
        Balance += amount;
        Console.WriteLine($"Deposited {amount} to Savings Account {AccountNumber}. New Balance: {Balance}");
    }

    public override void Withdraw(decimal amount)
    {
        if (amount > Balance)
        {
            throw new InvalidOperationException("Insufficient funds.");
        }
        Balance -= amount;
        Console.WriteLine($"Withdrew {amount} from Savings Account {AccountNumber}. New Balance: {Balance}");
    }

    public override void DisplayAccountInfo()
    {
        Console.WriteLine($"Savings Account {AccountNumber} - Balance: {Balance}, Interest Rate: {interestRate}%");
    }
}
