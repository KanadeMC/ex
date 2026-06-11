namespace Exam;

public class Z7
{
    public class P1 : IRunnable
    {
        //Практика: Метод string ReverseString(string s)
        //– возвращает строку задом наперёд (цикл или new string(s.Reverse().ToArray())).
        public void Run()
        {
            Console.WriteLine(ReverseString("Hulo"));
        }

        public string ReverseString(string s)
        {
            return new string(s.Reverse().ToArray());
        }
    }
    public class P2 : IRunnable
    {
        //Практика: Исправьте имена переменных по C# Style Guide:
        // int MaxValue = 100;
        // int user_age = 25;
        // float Temp = 36.6f;

        public void Run()
        {
            int maxValue = 100;
            int userAge = 25;
            float temp = 36.6f;
        }
    }
}