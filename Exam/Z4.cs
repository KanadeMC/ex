using System.Diagnostics;

namespace Exam;

public class Z4
{
    public class P1 : IRunnable
    {
        //Практика: Напишите метод bool IsEven(int n), возвращает true для чётного числа.
        public void Run()
        {
            Console.WriteLine(IsEven(5));
        }

        public bool IsEven(int n)
        {
            return n % 2 == 0;
        }
    }
    public class P2 : IRunnable
    {
        //Практика: Напишите 3 теста: для чётного, нечётного и нуля.
        public void Run()
        {
            Debug.Assert(IsEven(4) == true); //Четное
            Debug.Assert(IsEven(5) == false); // Нечетное
            Debug.Assert(IsEven(0) == true); // Ноль
        }
        public bool IsEven(int n)
        {
            return n % 2 == 0;
        }
    }
}