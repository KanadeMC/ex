using System.Diagnostics;

namespace Exam;

public class Z8
{
    public class P1 : IRunnable
    {
        //Практика: Метод bool IsPalindrome(string s) – проверка на палиндром.
        public void Run()
        {
            IsPalindrome("шалаш");
        }

        public bool IsPalindrome(string s)
        {
            if (s.ToLower() == new string(s.Reverse().ToArray()))
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
        //Практика: Тесты: "кот" (false), "шалаш" (true).
        public void Run()
        {
            Debug.Assert(IsPalindrome("кот") == false);
            Debug.Assert(IsPalindrome("шалаш") == true);
        }
        public bool IsPalindrome(string s)
        {
            if (s.ToLower() == new string(s.Reverse().ToArray()))
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