using System.Diagnostics;

namespace Exam;

public class Z1
{
    public class P1 : IRunnable
    {
        //Практика: Напишите метод bool IsDivider(int a, int b),
        //который проверяет, является ли a делителем b. Возвращает true или false.
        public void Run()
        {
            Console.WriteLine(IsDivider(5, 10));
            Console.WriteLine(IsDivider(6, 10));
        }

        public bool IsDivider(int a, int b)
        {
            if (b % a == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public class P2 : IRunnable
    {
        //Практика: Напишите 2 теста (с помощью Debug.Assert или Console.WriteLine)
        //для метода из задания 3: позитивный и негативный.
        public void Run()
        {
            Debug.Assert(IsDivider(5, 10) == true, "Позитивный тест");
            Debug.Assert(IsDivider(6, 10) == false, "Негативный тест"); 
        }
        public bool IsDivider(int a, int b)
        {
            if (b % a == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}