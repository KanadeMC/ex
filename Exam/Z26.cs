using System.Diagnostics;

namespace Exam;

public class Z26
{
    public class P1 : IRunnable
    {
        //Практика: Метод int ReverseNumber(int n) – переворачивает число (123 → 321). Без строк.
        public void Run()
        {
            Console.WriteLine(ReverseNumber(123));
        }

        int ReverseNumber(int n)
        {
            int reversed = 0;
            while (n != 0)
            {
                int digit = n % 10;
                reversed = reversed * 10 + digit;
                n /= 10;
            }
            return reversed;
        }
    }
    public class P2 : IRunnable
    {
        //Практика: Тесты: 123 → 321, 5000 → 5.
        public void Run()
        {
            int t = 123;
            int t2 = 5000;
            Debug.Assert(ReverseNumber(t) == 321);
            Debug.Assert(ReverseNumber(t2) == 5);
        }
        int ReverseNumber(int n)
        {
            int reversed = 0;
            while (n != 0)
            {
                int digit = n % 10;
                reversed = reversed * 10 + digit;
                n /= 10;
            }
            return reversed;
        }
    }
}