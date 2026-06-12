using System.Diagnostics;

namespace Exam;

public class Z21
{
    public class P1 : IRunnable
    {
        //Практика: Метод bool HasDuplicates(List<int> lst) – есть ли повторяющиеся элементы.
        public void Run()
        {
            Console.WriteLine(HasDuplicates(new List<int>([1,2,3,4,5])));
        }

        public bool HasDuplicates(List<int> lst)
        {
            List<int> temp = new();
            foreach (int i in lst)
            {
                if (temp.Contains(i))
                {
                    return true; 
                }
                temp.Add(i);
            }
            return false;
        }
    }
    public class P2 : IRunnable
    {
        //Практика: Тесты: [1,2,2,3] → true, [1,2,3] → false.
        public void Run()
        {
            List<int> t = new List<int>([1,2,2,3]);
            List<int> t1 = new List<int>([1,2,3]);
            Debug.Assert(HasDuplicates(t) == true);
            Debug.Assert(HasDuplicates(t1) == false);
        }
        public bool HasDuplicates(List<int> lst)
        {
            List<int> temp = new();
            foreach (int i in lst)
            {
                if (temp.Contains(i))
                {
                    return true; 
                }
                temp.Add(i);
            }
            return false;
        }
    }
}