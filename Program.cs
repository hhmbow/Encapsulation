using System;

public class BankAccount
{
    private string accountNumber;
    private decimal balance;

    public BankAccount(string accountNumber)
    {
        this.accountNumber = accountNumber;
        this.balance = 0;
    }

    // Encapsulated methods to access and modify balance
    public void Deposit(decimal amount)
    {
        if (amount > 0)
            balance += amount;
        else
            Console.WriteLine("Invalid amount for deposit.");
    }

    public void Withdraw(decimal amount)
    {
        if (amount > 0 && balance >= amount)
            balance -= amount;
        else
            Console.WriteLine("Invalid amount for withdrawal or insufficient funds.");
    }

    // Encapsulated property to access account number
    public string AccountNumber
    {
        get { return accountNumber; }
    }

    // Encapsulated property to access balance
    public decimal Balance
    {
        get { return balance; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating a bank account object
        BankAccount account = new BankAccount("123456789");

        // Depositing and withdrawing
        account.Deposit(1000);
        account.Withdraw(500);

        // Accessing account information
        Console.WriteLine($"Account Number: {account.AccountNumber}");
        Console.WriteLine($"Balance: {account.Balance}");
    }
}
