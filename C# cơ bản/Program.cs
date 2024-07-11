using System;

namespace BàiTập
{
  public class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("1. Tính tổng dãy số");
      Console.WriteLine("2. Tìm số nguyên tố");
      Console.WriteLine("Chọn chức năng (1 hoặc 2):");
      string input = Console.ReadLine();

      if (input == "1")
      {
        Calculator.Sum();
      }
      else if (input == "2")
      {
        Calculator.FindPrimeNumber();
      }
      else
      {
        Console.WriteLine("Chức năng không tồn tại");
      }
    }
  }
}
