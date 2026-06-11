namespace Exam;

public class Z11
{
    public class P1 : IRunnable
    {
        //Практика: Метод int MaxOfThree(int a, int b, int c) – максимум из трёх.
        public void Run()
        {
            Console.WriteLine(MaxOfThree(1,7,2));
        }

        public int MaxOfThree(int a, int b, int c)
        {
            List<int> l = new List<int>{a,b,c};
            return l.Max();
        }
    }
    public class P2 : IRunnable
    {
        //Практика: Исправьте код под C# Style Guide:
        //public static int Max(int x,int y){if(x>y)return x;return y;}

        public void Run()
        {
            Console.WriteLine(Max(5, 3));
        }
        // Правильный вариант
        public static int Max(int firstNumber, int secondNumber)
        {
            if (firstNumber > secondNumber)
            {
                return firstNumber;
            }
            else
            {
                return secondNumber;
            }
        }
    }
}