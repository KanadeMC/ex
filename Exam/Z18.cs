using System.Diagnostics;

namespace Exam;

public class Z18
{
    public class P1 : IRunnable
    {
        //Практика: Метод int CountWords(string text) – количество слов (разделены пробелами).
        public void Run()
        {
            string text = "Санчо 117 ваще красавчик";
            Console.WriteLine($"Текст \"{text}\" содержит {CountWords(text)} слов");
        }

        public int CountWords(string text)
        {
            return text.Split(' ').Length;
        }
    }
    public class P2 : IRunnable
    {
        //Практика: Тесты: "привет мир", "" (пустая строка).
        public void Run()
        {
            string t = "привет мир";
            string t2 = "";
            Debug.Assert(CountWords(t) == 2);
            Debug.Assert(CountWords(t2) == 0);
        }
        public int CountWords(string text)
        {
            if (text.Length <= 0)
            {
                return 0;
            }
            else
            {
                return text.Split(' ').Length;
            }
        }
    }
}