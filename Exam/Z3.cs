using System.Diagnostics;

namespace Exam;

public class Z3
{
    public class P1 : IRunnable
    {
        //Практика: Напишите метод int FindMin(List<int> numbers),
        //который находит минимальное число в списке (не используйте .Min()).
        public void Run()
        {
            List<int> t = new List<int>([52,62,42,67,117]);
            Debug.Assert(FindMin(t) == t.Min());
        }

        public int FindMin(List<int> numbers)
        {
            int min = numbers[0];
            int count = numbers.Count;
            for (int i = 0; i < count; i++)
            {
                if (min > numbers[i])
                {
                    min = numbers[i];
                }
            }
            return min;
        }
    }
    public class P2 : IRunnable
    {
        public void Run()
        {
            //public static int Summa(int a,int b){return a+b;}
            //public static int Mult(int a,int b){return a*b;}
            // ---------->
            // public static int Sum(int firstNumber, int secondNumber)
            // {
            //     return firstNumber + secondNumber;
            // }
            //
            // public static int Multiply(int firstNumber, int secondNumber)
            // {
            //     return firstNumber * secondNumber;
            // }

        }
    }
}