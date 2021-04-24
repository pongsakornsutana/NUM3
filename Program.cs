using System;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            char name = char.Parse(Console.ReadLine());
            int W, H, N ,a=1;

            H = int.Parse(Console.ReadLine());
            W = int.Parse(Console.ReadLine());
            N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= W; j++) 
                {
                    for (int k = 1;k <=H*a; k++ ){
                        Console.Write("{0}",name);
                    }
                    Console.WriteLine(" ");
                }
                a = a + 1;
            }
        }
    }
}
