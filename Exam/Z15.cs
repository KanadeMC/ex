namespace Exam;

public class Z15
{
    public class P1 : IRunnable
    {
        //Практика: Метод int FindSecondMax(List<int> numbers) – второе по величине число (числа разные).
        public void Run()
        {
            Console.WriteLine(FindSecondMax(new List<int>([117,256,13,67])));
        }

        public int FindSecondMax(List<int> numbers)
        {
            numbers.Sort();
            int fm = 0;
            int sm = 0;
            foreach (int i in numbers)
            {
                sm = fm;
                if (i > fm)
                {
                    fm = i;
                }
            }
            return sm;
        }
    }
    public class P2 : IRunnable
    {
        //Практика: Исправьте форматирование:
        //public static int Summa(int a,int b){int result=a+b;return result;}

        public void Run()
        {
            Console.WriteLine(Summa(117, 117));
        }

        public static int Summa(int a, int b)
        {
            int result = a + b;
            return result;
        }
    }
}