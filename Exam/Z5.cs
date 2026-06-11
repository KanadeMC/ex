namespace Exam;

public class Z5
{
    public class P1 : IRunnable
    {
        //Практика: Метод int CountPositive(List<int> numbers) – количество положительных чисел.
        public void Run()
        {
            List<int> t = new List<int>([1,2,5,6,-6,-2,0]);
            Console.WriteLine(CountPositive(t));
        }

        public int CountPositive(List<int> numbers)
        {
            int positiveCount = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > 0)
                {
                    positiveCount++;
                }
            }
            return positiveCount;
        }
    }   
    public class P2 : IRunnable
    {
        //Практика: Найдите 2 стилевые ошибки и исправьте:
        //public static void CheckAge(int age)
        //{
        //if(age>=18)
        //Console.WriteLine("Совершеннолетний");
        //else Console.WriteLine("Несовершеннолетний");
        //}
        public void Run()
        {
            CheckAge(117);
        }
        // Правильный вариант CTRL+C + CTRL+V
        public static void CheckAge(int age)
        {
            if (age >= 18)
            {
                Console.WriteLine("Совершеннолетний");
            }
            else
            {
                Console.WriteLine("Несовершеннолетний");
            }
        }
    }
}