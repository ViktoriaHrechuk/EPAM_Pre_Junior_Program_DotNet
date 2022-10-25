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
    Console.WriteLine("Загальна сума покупки = {0} грн", totalPrice);
  }
}