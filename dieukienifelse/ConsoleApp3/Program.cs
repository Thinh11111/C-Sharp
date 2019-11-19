using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            int b = 200;
            if(a==100)
            {
                if(b==200)
                {
                    Console.WriteLine("gia tri cua a la 100 b la 200");
                }
            }
            Console.WriteLine("gia tri cua a la {0}", a);
            Console.WriteLine("gia tri cua b la {0}", b);
        }
    }
}
