using System.Diagnostics;

namespace Exam;

public class Z25
{
    public class P1 : IRunnable
    {
        //Практика: Метод string CapitalizeWords(string s) – каждое слово с заглавной буквы.
        public void Run()
        {
            Console.WriteLine(CapitalizeWords("hello world"));
        }

        public string CapitalizeWords(string s)
        {
            string[] split = s.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string result = "";
            foreach (var word in split)
            {
                result += word[0].ToString().ToUpper() + word.Substring(1) + " ";
            }
            return result.TrimEnd(); 
        }

    }
    public class P2 : IRunnable
    {
        //Практика: Тесты: "привет мир" → "Привет Мир", "один" → "Один".
        public void Run()
        {
            string t = "привет мир";
            string t2 = "один";
            Debug.Assert(CapitalizeWords(t) == "Привет Мир");
            Debug.Assert(CapitalizeWords(t2) == "Один");
        }
        public string CapitalizeWords(string s)
        {
            string[] split = s.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string result = "";
            foreach (var word in split)
            {
                result += word[0].ToString().ToUpper() + word.Substring(1) + " ";
            }
            return result.TrimEnd(); 
        }
    }
}