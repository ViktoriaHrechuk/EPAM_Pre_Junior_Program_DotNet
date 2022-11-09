using System;
using System.Linq;

public class Program
{
  public static void Main()
  {
    int minNumber = 1;
    int maxNumber = 1000000000;

    Console.WriteLine("Будь ласка, введіть число від {0} до {1}.", minNumber, maxNumber);
    string stringNumber = Console.ReadLine();

    int number;
    bool isNumber = int.TryParse(stringNumber, out number);

    if (!isNumber)
    {
      Console.WriteLine("Введено не правильне значення. Будь ласка, введіть ціле число в діапазоні від {0} до {1}.", minNumber, maxNumber);
      return;
    }

    if (number < minNumber || number > maxNumber)
    {
      Console.WriteLine("Введено некоректне число. Число має бути в діапазоні від {0} до {1}.", minNumber, maxNumber);
      return;
    }

    int sum = 0;

    for (int i = 0; i < stringNumber.Length; i++)
    {
      int primeNumber = int.Parse(stringNumber[i].ToString());
      sum += primeNumber;
    }


    Console.WriteLine("Сума = {0}", sum);
  }
}