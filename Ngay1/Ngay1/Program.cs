using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ngay1
{
    class Program
    {
        static void VD1()
        {
            Console.WriteLine("Lệnh if trong C#");
            Console.WriteLine("--------------");

            int a = 10;
            if (a< 20)
            {
                Console.WriteLine("a nhỏ hơn  20");
            }
            Console.WriteLine("Giá trị của a là: {0}", a);
            
        }
        static void VD2()
        {
            int a = 100;
            if (a > 20)
            {
                Console.WriteLine("A lớn hơn 20");
            }
            else
            {
                Console.WriteLine("A không nhỏ hơn 20");
            }
            Console.WriteLine("Giá trị của a là:{0}", a);
        }
        static void VD3()
        {
            int a=100;
            int b = 200;
            if (a == 100) {
                if (b == 200)
                {
                    Console.WriteLine("Giá trị của a là:100 và b là 200");
                }
            }
            Console.WriteLine("Giá trị chính xác của a là:{0}", a);
            Console.WriteLine("Giá trị chính xác của b là:{0}", b);
        }
        static void VD4()
        {
            char grade = 'B';
            switch (grade)
            {
                case 'A':
                    Console.WriteLine("Xuất sắc!");
                    break;
                case 'B':
                case 'C':
                    Console.WriteLine("Giỏi");
                    break;
                case 'D':
                    Console.WriteLine("Trung Bình");
                    break;
                case 'F':
                    Console.WriteLine("Học Lại");
                    break;
                default:
                    Console.WriteLine("Giá trị không hợp lệ");
                    break;
            }
            Console.WriteLine("Học lực của bạn là: {0}", grade);
        }
        static void VD5()
        {
            Console.WriteLine("Lồng các lệnh switch trong C#");
            Console.WriteLine("-----------------------------");

            int a = 100;
            int b = 200;
            switch (a)
            {
                case 100:
                    Console.WriteLine("Dòng này thuộc lệnh switch bên ngoài");
                    switch (b)
                    {
                        case 200:
                            Console.WriteLine("Dòng nay thuộc lệnh switch bên trong");
                            break;
                    }
                    break;
            }
            Console.WriteLine("Giá trị chính xác của a là: {0}", a);
            Console.WriteLine("Giá trị chính xác của b là: {0}", b);
        }
        static void VD6()
        {
            Console.WriteLine("Vòng lặp while trong C#");
            Console.WriteLine("------------------------");

            int a = 10;
            while (a < 20)
            {
                Console.WriteLine("Giá trị của là: {0}", a);
                a++;
            }
        }
        static void VD7()
        {
            Console.WriteLine("Vòng lặp for trong C#");
            Console.WriteLine("------------------------");
            
            for(int a = 10; a < 20; a++)
            {
                Console.WriteLine("Giá trị của a la:{0}", a);
            }
        }
        static void VD8()
        {
            Console.WriteLine("Vòng lặp do..while trong C#");
            Console.WriteLine("------------------------");

            int a = 10;
            do
            {
                Console.WriteLine("Giá trị của a là: {0}",a);
                a++;
            }
            while (a < 20);
        }
        static void VD9()
        {
            Console.WriteLine("Lồng vòng lặp trong C#");
            Console.WriteLine("Tìm số nguyên tố trong C#");
            Console.WriteLine("------------------------");

            int i, j;
            for (i = 2; i < 100; i++)
            {
                for (j = 2; j <= (i / j); j++)
                    if ((i % j) == 0) break;
                if (j > (i / j))
                    Console.WriteLine("{0} là số nguyên tố", i);
            }
        }
  
        static void VD10()
        {
            Console.WriteLine("Tính đóng gói trong c#");
            Console.WriteLine("-----------------------");

            Rectangle r = new Rectangle();
            r.length = 4.5;
            r.width = 3.5;
            r.Display();
            //r.Acceptdetails();
            //r.Display();
        }
        static void VD11()
        {
            Console.WriteLine("Gọi phương thức trong C#");
            Console.WriteLine("-------------------------");

            int a = 100;
            int b = 200;
            int ret;
            TestCsharp n = new TestCsharp();

            //gọi phương thức Findmax
            ret = n.FindMax(a, b);
            Console.WriteLine("Giá trị lớn nhất là:{0}", ret);
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //VD1();
            //VD2();
            //VD3();
            //VD4();
            //VD5();
            //VD6();
            //VD7();
            //VD8();
            //VD9();
            //VD10();
            VD11();


            Console.ReadLine();
        }
    }
}
