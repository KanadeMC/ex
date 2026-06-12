using System.Diagnostics;

namespace Exam;

public class Z23
{
    public class P1 : IRunnable
    {
        //Практика: Метод int LinearSearch(int[] arr, int target) – индекс первого вхождения или -1.
        public void Run()
        {
            Console.WriteLine(LinearSearch(new []{1,2,3,45,68,99,117,117},117));
        }

        public int LinearSearch(int[] a, int target)
        {
            if (a.Contains(target))
            {
                return a.IndexOf(target);
            }
            return -1;
        }
    }
    public class P2 : IRunnable
    {
        //Практика: Тесты: элемент есть, элемента нет.
        public void Run()
        {
            Debug.Assert(LinearSearch(new []{1,2,3,45,68,99,117,117},117)==6);
            Debug.Assert(LinearSearch(new []{1,2,3,45,68,99,117,117},116)==-1);
        }
        public int LinearSearch(int[] a, int target)
        {
            if (a.Contains(target))
            {
                return a.IndexOf(target);
            }
            return -1;
        }
    }
}