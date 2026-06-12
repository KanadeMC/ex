using System.Diagnostics;

namespace Exam;

public class Z20
{
    public class P1 : IRunnable
    {
        //Практика: Метод int Gcd(int a, int b) – НОД (алгоритм Евклида, цикл).
        public void Run()
        {
            Console.WriteLine(Gcd(117,84));
        }

        public int Gcd(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }
    public class P2 : IRunnable
    {
        //Практика: Тесты: (12,18) → 6, (7,13) → 1.
        public void Run()
        {
            List<int> t = new List<int>([12, 18]);
            List<int> t2 = new List<int>([7, 13]);
            Debug.Assert(Gcd(t[0],t[1]) == 6);
            Debug.Assert(Gcd(t2[0],t2[1]) == 1);
        }
        public int Gcd(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }
}