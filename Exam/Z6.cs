using System.Diagnostics;

namespace Exam;

public class Z6
{
    public class P1 : IRunnable
    {
        //Практика: Метод int Factorial(int n) – факториал через for.
        public void Run()
        {
            Console.WriteLine(Factorial(10));
        }

        public Int64 Factorial(int n)
        {
            Int64 result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
    public class P2 : IRunnable
    {
        //Практика: Тесты для n=3 и n=1
        public void Run()
        {
            Debug.Assert(Factorial(1)==1);
            Debug.Assert(Factorial(3)==6);
        }
        
        public Int64 Factorial(int n)
        {
            Int64 result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}