using System;

public class BankAccount
{
    private bool isOpened = false;
    private decimal currentBalance = 0;
    private readonly object balance = new object();

    public void Open() => isOpened = true;

    public void Close() => isOpened = false;

    public decimal Balance
    {
        get
        {
            return isOpened ? currentBalance : throw new InvalidOperationException();
        }
    }

    public void UpdateBalance(decimal change)
    {
        lock (balance)
        {
            currentBalance += change;
        }
    }
}
