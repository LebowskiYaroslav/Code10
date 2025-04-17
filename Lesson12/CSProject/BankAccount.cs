using System;

public class BankAccount
{
    private decimal balance;

    public event Action<decimal, decimal> BalanceChanged;

    public BankAccount(decimal initialBalance)
    {
        balance = initialBalance;
    }

    public decimal Balance
    {
        get { return balance; }
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Deposit amount must be positive.");

        decimal oldBalance = balance;
        balance += amount;
        OnBalanceChanged(oldBalance, balance);
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Withdrawal amount must be positive.");
        if (amount > balance)
            throw new InvalidOperationException("Insufficient funds.");

        decimal oldBalance = balance;
        balance -= amount;
        OnBalanceChanged(oldBalance, balance);
    }

    protected virtual void OnBalanceChanged(decimal oldBalance, decimal newBalance)
    {
        BalanceChanged?.Invoke(oldBalance, newBalance);
    }
}
