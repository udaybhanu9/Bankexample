
using System;

class Sample
{
    static void Main()
    {
        Bank bank= new Bank("Lee",1,4545);

        bank.Deposit(4545);
        bank.WithDrawl(2006);
        Console.WriteLine(bank.getName());
        Console.WriteLine("Hello User");
        Console.ReadKey();
        Console.WriteLine("hi uday");
    }
}