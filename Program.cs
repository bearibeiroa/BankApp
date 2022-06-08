using System;

namespace MySuperBankApp
{
  class Program
  {
    static void Main(string[] args)
    {
      var account = new BankAccount("Beatriz", 10000);
      Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");

      account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
    //   Console.WriteLine($"After whithdrawl Rent payment you have ${account.Balance}");

      account.MakeWithdrawal(50, DateTime.Now, "Xbox Game");
    //   Console.WriteLine($"After whithdrawl Xbox Game you have ${account.Balance}");
      
      Console.WriteLine(account.GetAccountHistory());

      /* try
      {
        account.MakeWithdrawal(750, DateTime.Now, "Attempt to overdraw");
      }
      catch (InvalidOperationException e)
      {
        Console.WriteLine("Exception caught trying to overdraw");
        Console.WriteLine(e.ToString());
      }

      try
      {
        var invalidAccount = new BankAccount("invalid", -55);
      }
      catch (ArgumentOutOfRangeException error)
      {
        Console.WriteLine("Exception caught creating account with negative balance");
        Console.WriteLine(error.ToString());
      } */
    }
  }
}
