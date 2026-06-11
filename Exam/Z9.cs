namespace Exam;

public class Z9
{
    public class P1 : IRunnable
    {
        //Практика: Метод int SumOfDigits(int n) – сумма цифр числа (например, 123 → 6).
        public void Run()
        {
            Console.WriteLine(SumOfDigits(123));
        }

        public int SumOfDigits(int n)
        {
            int sum = 0;
            string r = new string(n.ToString().ToArray());
            foreach (char c in r)
            {
                sum += int.Parse(c.ToString());
            }
            return sum;
        }
    }
    public class P2 : IRunnable
    {
        //Практика: Найдите 3 ошибки форматирования и исправьте:
        //public static int Calc(int a,int b){if(a>b)return a;else return b;}

        public void Run()
        {
            Calc(3, 1);
        }

        public static int Calc(int a, int b)
        {
            if(a>b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }
}