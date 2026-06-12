using System.Diagnostics;

namespace Exam;

public class Z16
{
    public class P1 : IRunnable
    {
        //Практика: Метод List<int> RemoveDuplicates(List<int> lst) – удаляет повторы, порядок сохраняется.
        public void Run()
        {
            List<int> t = new List<int>([1,6,8,32,4,727,2,8,3,6]);
            List<int> t2 = new List<int>([1,6,8,32,4,727,2,3]);
            t = RemoveDuplicates(t);
            t2 = RemoveDuplicates(t2);
            foreach (int i in t)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\n");
            foreach (int i in t2)
            {
                Console.WriteLine(i);
            }
        }

        public List<int> RemoveDuplicates(List<int> lst)
        {
            List<int> temp = new();
            foreach (var i in lst)
            {
                if (temp.Contains(i))
                {
                    
                }
                else
                {
                    temp.Add(i);
                }
            }
            return temp;
        }
    }
    public class P2 : IRunnable
    {
        //Практика: Тесты: с повторами и без повторов.
        public void Run()
        {
            List<int> t = new List<int>([1,6,8,32,4,727,2,8,3,6]);
            List<int> t2 = new List<int>([1,6,8,32,4,727,2,3]);
            Debug.Assert(t2.SequenceEqual(RemoveDuplicates(t)));
            Debug.Assert(t2.SequenceEqual(RemoveDuplicates(t2)));
        }
        public List<int> RemoveDuplicates(List<int> lst)
        {
            List<int> temp = new();
            foreach (var i in lst)
            {
                if (temp.Contains(i))
                {
                    
                }
                else
                {
                    temp.Add(i);
                }
            }
            return temp;
        }
    }
}