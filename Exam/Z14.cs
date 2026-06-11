using System.Diagnostics;

namespace Exam;

public class Z14
{
    public class P1 : IRunnable
    {
        //Практика: Метод int Fibonacci(int n) – n-е число Фибоначчи (цикл).
        public void Run()
        {
            Console.WriteLine(Fibonacci(10));
        }

        public int Fibonacci(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
    
            int previous = 0;  // F(0)
            int current = 1;   // F(1)
    
            for (int i = 2; i <= n; i++)
            {
                int next = previous + current;
                previous = current;
                current = next;
            }
    
            return current;
        }
    }
    public class P2 : IRunnable
    {
        //Практика: Тесты: n=1 → 1, n=5 → 5.
        public void Run()
        {
            Debug.Assert(Fibonacci(1) == 1);
            Debug.Assert(Fibonacci(5) == 5);
        }
        public int Fibonacci(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
    
            int previous = 0;  // F(0)
            int current = 1;   // F(1)
    
            for (int i = 2; i <= n; i++)
            {
                int next = previous + current;
                previous = current;
                current = next;
            }
    
            return current;
        }
    }
}