using System;

namespace text4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("2~100內的素數:");
            Decide();
        }
        static void Decide()
        {
            bool[] number;
            number = new bool[101];
            for (int i = 2; i <= 100; i++)//初始化數組
                number[i] = true;
            number[0] = number[1] = false;//0和1都不是素數
            for (int i = 2; i <= 100; i++)
            {
                if (number[i])
                {
                    for (int j = i * 2; j <= 100; j += i)
                    {
                        number[j] = false;
                    }
                    Console.Write("{0} ", i);
                }
            }     
        }
    }
}
