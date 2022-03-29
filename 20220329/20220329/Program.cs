using System;

namespace ConsoleApp1
{
    class Program
    {
        static void SumAvg(int[] a)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
                sum += a[i];
            Console.WriteLine("합계: " + sum);
            Console.WriteLine("평균: " + sum / a.Length);
        }
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };
            SumAvg(array);
        }


    }
}