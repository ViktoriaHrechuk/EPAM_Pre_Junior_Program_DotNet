using System;

public class Program
{
  public static void Main()
  {
    Console.WriteLine("Введіть кількість ручок.");
    int penAmount = int.Parse(Console.ReadLine());

    Console.WriteLine("Введіть вартість ручки.");
    double penPrice = double.Parse(Console.ReadLine());

    Console.WriteLine("Введіть кількість зошитів.");
    int copybookAmount = int.Parse(Console.ReadLine());

    Console.WriteLine("Введіть вартість зошита.");
    double copybookPrice = double.Parse(Console.ReadLine());

    double totalPrice = penAmount * penPrice + copybookAmount * copybookPrice;

    Console.WriteLine("Скільки Петрик має грошей?");
    double totalMoney = double.Parse(Console.ReadLine());

    double moneyDeposit = totalMoney - totalPrice;

    Console.WriteLine("Всього Петрик має {0} грн", totalMoney);
    Console.WriteLine("Загальна сума покупки {0} грн", totalPrice);

    if (moneyDeposit > 0)
    {
      Console.WriteLine("У Петрика залишилося {0} грн", moneyDeposit);
    }
    else if (moneyDeposit == 0)
    {
      Console.WriteLine("Петрик в змозі то купити, але залишиться без грошей 😅");
    }
    else
    {
      Console.WriteLine("Петрик не може собі то дозволити 😕 Петрику не вистачає {0} грн 🥲", Math.Abs(moneyDeposit));
    }
  }
}
