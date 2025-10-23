namespace ClassTests
{
    // Abstract class representing a bank account
    public abstract class ABankAccount(string accountNumber, decimal initialBalance)
    {
        // Properties
        public string AccountNumber { get; private set; } = accountNumber;
        public decimal Balance { get; protected set; } = initialBalance;

        // Abstract methods
        public abstract void Deposit(decimal amount);
        public abstract void Withdraw(decimal amount);
        public abstract void DisplayAccountInfo();
    }
}
