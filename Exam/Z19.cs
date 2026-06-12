namespace Exam;

public class Z19
{
    public class P1 : IRunnable
    {
        //Практика: Метод List<int> SquareNumbers(List<int> numbers) – список квадратов.
        public void Run()
        {
            List<int> t = new List<int>([1, 2, 5, 7, 8, 3, 4, 6]);
            t = SquareNumbers(t);
            foreach (int i in t)
            {
                Console.WriteLine(i);
            }
        }

        public List<int> SquareNumbers(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i] = Convert.ToInt32(MathF.Pow(numbers[i],2));
            }
            return numbers;
        }
    }
    public class P2 : IRunnable
    {
        //Практика: Исправьте отступы:
        //public static void Check(int x) { if(x>0) { Console.WriteLine("Положительное"); } else { Console.WriteLine("Не положительное"); } }

        public void Run()
        {
            Check(5);
        }

        public static void Check(int x)
        {
            if (x > 0)
            {
                Console.WriteLine("Положительное");
            }
            else
            {
                Console.WriteLine("Не положительное");
            }
        }
    }
}