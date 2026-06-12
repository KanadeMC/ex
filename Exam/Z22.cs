namespace Exam;

public class Z22
{
    public class P1 : IRunnable
    {
        //Практика: Метод int[] BubbleSort(int[] arr) – сортировка пузырьком.
        public void Run()
        {
            int[] arr = BubbleSort(new[] { 3, 2, 5, 6, 1 });
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
        }
        public static int[] BubbleSort(int[] a)
        {
            int n = a.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        (a[j],a[j+1])=(a[j+1],a[j]);
                    }
                }
            }
            return a;
        }
    }
    public class P2 : IRunnable
    {
        //Практика: Исправьте стиль:
        //public static int[] BUBBLE_SORT(int[] A) { int n = A.Length; for(int i=0;i<n;i++) for(int j=0;j<n-1;j++) if(A[j]>A[j+1]) (A[j],A[j+1])=(A[j+1],A[j]); return A; }

        public void Run()
        {
            int[] arr = BubbleSort(new[] { 3, 2, 5, 6, 1 });
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
        }

        public static int[] BubbleSort(int[] a)
        {
            int n = a.Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        (a[j],a[j+1])=(a[j+1],a[j]);
                    }
                }
            }
            return a;
        }
    }
}