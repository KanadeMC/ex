namespace Exam;

public class Z24
{
    public class P1 : IRunnable
    {
        //Практика: Метод int MatrixSum(int[,] matrix) – сумма всех элементов.
        public void Run()
        {
            int[,] staticMatrix = {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            PrintMatrix(staticMatrix);
        }
        static void PrintMatrix(int[,] m)
        {
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    Console.Write(m[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
    public class P2 : IRunnable
    {
        //Практика: Найдите 2 стилевые ошибки:
        //static void PrintMatrix(int[,] m) { for(int i=0;i<m.GetLength(0);i++) { for(int j=0;j<m.GetLength(1);j++) Console.Write(m[i,j]+" "); Console.WriteLine(); } }

        public void Run()
        {
            int[,] staticMatrix = {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };
            PrintMatrix(staticMatrix);
        }

        static void PrintMatrix(int[,] m)
        {
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    Console.Write(m[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}