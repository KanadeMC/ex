namespace Exam;

public class Z13
{
    public class P1 : IRunnable
    {
        //Практика: Метод int MultiplyList(List<int> numbers) – произведение всех чисел.
        public void Run()
        {
            Console.WriteLine(MultiplyList(new List<int>([1, 2, 3, 4, 5, 6, 7])));
        }

        public int MultiplyList(List<int> numbers)
        {
            int total = 1;
            foreach (int i in numbers)
            {
                total *= i;
            }
            return total;
        }
    }
    public class P2 : IRunnable
    {
        //Практика: Найдите 2 стилевые ошибки:
        //public static bool CheckPositive(int x){if(x>0)return true;return false;}

        public void Run()
        {
            Console.WriteLine(CheckPositive(1));
        }

        public static bool CheckPositive(int x)
        {
            if (x > 0)
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