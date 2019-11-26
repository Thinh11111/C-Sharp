using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ngay2
{
    class Student
    {
        private int SID;
        private string TenSV;
        private string Khoa;
        private float DiemTB;
        public Student()
        {
            SID = 1;
            TenSV = "Nguyen Van Nam";
            Khoa = "CNTT";
            DiemTB = 7;
        }
        public Student(Student stu)
        {
            SID = stu.SID;
            TenSV = stu.TenSV;
            Khoa = stu.Khoa;
            DiemTB = stu.DiemTB;
        }
        public Student(int id, string ten, string khoa, float dtb)
        {
            this.SID = id;
            this.TenSV = ten;
            this.Khoa = khoa;
            this.DiemTB = dtb;
        }
        public int StudentID
        {
            get { return SID; }
            set { SID = value; }
        }
        public string Name
        {
            get { return TenSV; }
            set { TenSV = value; }
        }
        public string Faculty
        {
            get { return Khoa; }
            set { Khoa = value; }
        }
        public float Mark
        {
            get { return DiemTB; }
            set { DiemTB = value; }
        }
        public void Nhap1SV()
        {
            Console.WriteLine("Nhập MaSV");
            SID = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập tên sinh viên");
            Name = Console.ReadLine();
            Console.WriteLine("Nhâp Khoa");
            Faculty = Console.ReadLine();
            Console.WriteLine("Nhập điểm trung bình");
            Mark = float.Parse(Console.ReadLine());
        }
        public void Show()
        {
            Console.WriteLine("MSVV:{0}", this.SID);
            Console.WriteLine("Tên SV:{0}", this.TenSV);
            Console.WriteLine("Khoa:{0}", this.Khoa);
            Console.WriteLine("Điểm Trung Bình:{0}", this.DiemTB);
        }
    }
}
