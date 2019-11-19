using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ngay1
{
    class Rectangle
    {
        //public double length;
        //public double width;

        //private double length;
        //private double width;

        internal double length;
        internal double width;
        public double GetArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("Chiều dài: {0}", length);
            Console.WriteLine("Chiều rộng: {0}", width);
            Console.WriteLine("Diện tích: {0}", GetArea());
        }
        public void Acceptdetails()
        {
            Console.WriteLine("Nhập vào chiều dài:");
            length = double.Parse(Console.ReadLine());
           // length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhập vào chiều rộng:");
            width = double.Parse(Console.ReadLine());
        }
    }
}
