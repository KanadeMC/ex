using System.Diagnostics;

namespace Exam;

public class Z12
{
    public class P1 : IRunnable
    {
        //Практика: Метод int CountVowels(string s) – количество гласных (а, е, ё, и, о, у, ы, э, ю, я).
        public void Run()
        {
            Console.WriteLine(CountVowels("Балабол"));
        }

        public int CountVowels(string s)
        {
            int vowels = 0;
            string gl = "а, е, ё, и, о, у, ы, э, ю, я";
            foreach (char c in s)
            {
                if (gl.Contains(c))
                {
                    vowels++;
                }
            }
            return vowels;
        }
    }
    public class P2 : IRunnable
    {
        //Практика: Тесты: "привет", "брр".
        public void Run()
        {
            Debug.Assert(CountVowels("привет") == 2);
            Debug.Assert(CountVowels("брр") == 0);
        }
        public int CountVowels(string s)
        {
            int vowels = 0;
            string gl = "а, е, ё, и, о, у, ы, э, ю, я";
            foreach (char c in s)
            {
                if (gl.Contains(c))
                {
                    vowels++;
                }
            }
            return vowels;
        }
    }
}