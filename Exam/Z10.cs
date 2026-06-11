using System.Diagnostics;

namespace Exam;

public class Z10
{
    public class P1 : IRunnable
    {
        //Практика: Метод bool IsLeapYear(int year) – високосный год (делится на 4, но не на 100, или на 400).
        public void Run()
        {
            IsLeapYear(2024);
        }

        public bool IsLeapYear(int year)
        {
            if (year % 4 == 0 && year % 100 != 0 && year % 400 == 0)
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
        //Практика: Тесты: 2024 → true, 2023 → false.
        public void Run()
        {
            Debug.Assert(IsLeapYear(2024) == true);
            Debug.Assert(IsLeapYear(2023) == false);
        }
        public bool IsLeapYear(int year)
        {
            if (year % 4 == 0 && year % 100 != 0 && year % 400 == 0)
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