

using System;
using System.Collections.Generic;



class BankAccount
{
    private double balanceM;
    public void Deposit(double amount)
    {
        balanceM += amount;
    }

    public void balance()
    {
        Console.WriteLine("Balance:" + balanceM);
    }
}



class Encap
{
    public static void Main(string[] args)
    {
        BankAccount BA = new BankAccount();
        BA.Deposit(1000.00);
        BA.Deposit(500.00);
        BA.balance();
    }
}