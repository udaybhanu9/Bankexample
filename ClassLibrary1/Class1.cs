using System;

public class Bank
{
    private string name;
    private int accno;
    private string password;
    private double balance;

    public Bank(string name,int accno,double balance)
    {
        this.name = name;
        this.accno = accno;        
        this.balance = balance;

    }

    public void Deposit(double Deposit)
    {
        this.balance += Deposit;
        Console.WriteLine("Deposit successful your current balance: "+balance);
    }
    public void WithDrawl(double Withdrawl)
    {
        if (balance- Withdrawl < 0)
        {
            Console.WriteLine("Insufficient balance");
        }
        else
        {
            balance -= Withdrawl;
            Console.WriteLine("Withdrawl successful your current balance: "+balance);
        }
       
    }
    public string getName()
    {
        return name;
    }
    public void setName(string Name)
    {
        this.name = Name;
    }
    public int getAccno()
    {
        return accno;
    }
    public void setAccno(int Accno)
    {
        this.accno = Accno;
    }
    public String getPassword()
    {
        return password;
    }
    public void setPassword(string Password)
    {
        this.password = Password;
    }
    public double getBalance()
    {
        return balance;
    }
    public void setBalance(double Balance)
    {
        this.balance = Balance;
    }

}