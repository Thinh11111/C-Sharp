using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ngay2
{
    class Program
    {
        static void VD1()
        {
            Student[] DSSV;
            int n;
            Console.WriteLine("Nhập số lượng sinh viên:");
            n = int.Parse(Console.ReadLine());
            DSSV = new Student[n];
            Console.WriteLine("--------NHẬP DANH SÁCH SINH VIÊN---------");
            for (int i = 0; i < n; i++)
            {
                DSSV[i] = new Student();
                Console.WriteLine("Nhập MaSV {0}:", i + 1);
                DSSV[i].StudentID = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhập họ tên SV:");
                DSSV[i].Name = Console.ReadLine();
                Console.WriteLine("Nhập khoa:");
                DSSV[i].Faculty = Console.ReadLine();
                Console.WriteLine("Nhập DTB:");
                DSSV[i].Mark = float.Parse(Console.ReadLine());
            }

            //Xuất DS Sinh viên
            Console.WriteLine("-----------Xuất danh sách sinh viên-----------");
            foreach (Student sv in DSSV)
            {
                sv.Show();
            }
        }
        static void NhapDS(int n)
        {
            Student[] DSSV;            
            DSSV = new Student[n];
            Console.WriteLine("--------NHẬP DANH SÁCH SINH VIÊN---------");
            for (int i = 0; i < n; i++)
            {
                DSSV[i] = new Student();
                DSSV[i].Nhap1SV();
            }
        }
        static void XuatDS(int n)
        {
            Student[] DSSV;
            DSSV = new Student[n];
            Console.WriteLine("--------DANH SÁCH SINH VIÊN---------");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Sinh Viên Thứ: {0}", i + 1);
                DSSV[i] = new Student();
                DSSV[i].Show();
            }

        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //VD1();

            /*Student sv = new Student();
            sv.Nhap1SV();
            sv.Show();*/

            int n;
            Console.WriteLine("Nhập số lượng sinh viên:");
            n = int.Parse(Console.ReadLine());
            NhapDS(n);
            XuatDS(n);

            Console.ReadLine();
        }
    }
}
