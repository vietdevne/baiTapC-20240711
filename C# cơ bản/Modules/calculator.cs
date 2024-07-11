using System;

namespace BàiTập
{
    public class Calculator
    {
        public static void Sum()
        {
            Console.WriteLine("Nhập dãy số nguyên cách nhau bằng dấu phẩy (ví dụ: 1,2,3,4,5):");
            string input = Console.ReadLine();

            string[] numbers = input.Split(',');

            int sum = 0;

            foreach (string number in numbers)
            {
                if (int.TryParse(number, out int result))
                {
                    sum += result;
                }
                else
                {
                    Console.WriteLine("Dãy số không hợp lệ");
                    return;
                }
            }
            Console.WriteLine("Tong cua day so la: " + sum);
        }

        public static void FindPrimeNumber()
        {
            Console.WriteLine("Nhập dãy số nguyên cách nhau bằng dấu phẩy (ví dụ: 1,2,3,4,5):");
            string input = Console.ReadLine();

            string[] numbers = input.Split(',');

            string[] results = new string[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (int.TryParse(numbers[i], out int result))
                {
                    if (IsPrime(result))
                    {
                        results[i] = result.ToString();
                    }
                }
                else
                {
                    Console.WriteLine("Dãy số không hợp lệ");
                    return;
                }
            }

            if (results.Length == 0)
            {
                Console.WriteLine("Không có số nguyên tố nào trong dãy số");
            }
            else
            {
                Console.WriteLine("Các số nguyên tố trong dãy số là: " + string.Join(", ", results));
            }
        }

        private static bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }
            if (number <= 3)
            {
                return true;
            }
            if (number % 2 == 0 || number % 3 == 0)
            {
                return false;
            }

            for (int i = 5; i * i <= number; i += 6)
            {
                if (number % i == 0 || number % (i + 2) == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}