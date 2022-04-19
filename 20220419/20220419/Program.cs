using System;

namespace ConsoleApp1
{
    class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("3개의 정수를 입력하세요:");
            int sum=0, n=0;
            for (int i = 0; i < 3 i++) ;
            try
        {
                n = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("정수가 아닙니다. 다시 입력하시오");
                i--;
                continue;
            }
            sum += n;
        }
        Console.writeLine("합계"+sum);


    }
}