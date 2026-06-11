using System.Diagnostics;

namespace Exam;

public class Z2
{
    public class P1 : IRunnable
    {
        //Практика: Напишите метод int SumOfList(List<int> nums),
        //который принимает список чисел и возвращает их сумму (не используйте .Sum()).
        public void Run()
        {
            List<int> n = new List<int>([1,2,3,4,5,6,7]);
            Console.WriteLine(SumOfList(n));
        }

        public int SumOfList(List<int> nums)
        {
            int count = nums.Count;
            int sum = 0;
            for (int i = 0; i < count; i++)
            {
                sum += nums[i];
            }
            return sum;
        }
    }
    public class P2 : IRunnable
    {
        //Практика: Напишите 2 теста для метода из
        //задания 3: с обычным списком и с пустым списком.
        public void Run()
        {
            List<int> t1 = new List<int>([1,2,3,4,5,6,7]);
            List<int> t2 = new List<int>();
            Debug.Assert(SumOfList(t1) == t1.Sum());
            Debug.Assert(SumOfList(t2) == t2.Sum());
        }
        public int SumOfList(List<int> nums)
        {
            int count = nums.Count;
            int sum = 0;
            for (int i = 0; i < count; i++)
            {
                sum += nums[i];
            }
            return sum;
        }
    }
}