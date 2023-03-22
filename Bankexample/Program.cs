
using System;

class Sample
{
    static void Main()
    {
        Bank bank= new Bank("Lee",1,2358);

        bank.Deposit(2358);
        bank.WithDrawl(2358);
        Console.WriteLine(bank.getName());
        Console.ReadKey();
    }
}