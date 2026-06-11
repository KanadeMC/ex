namespace Exam;

public class Z15
{
    public class P1 : IRunnable
    {
        //Практика: Метод int FindSecondMax(List<int> numbers) – второе по величине число (числа разные).
        public void Run()
        {
            Console.WriteLine(FindSecondMax(new List<int>([1,2,3,4,5,6,7])));
        }

        public int FindSecondMax(List<int> numbers)
        {
            int fm = 0;
            int sm = 0;
            foreach (int i in numbers)
            {
                if (i > fm)
                {
                    fm = i;
                }
                sm = i;
            }

            return sm;
        }
    }
    public class P2 : IRunnable
    {
        //
        public void Run()
        {
            
        }
    }
}