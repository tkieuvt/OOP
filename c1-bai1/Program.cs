using System;
namespace bai1c1
{
    class Program
    {
        static void Main(string[] args)
        {
            string ten,lop,loai;
            float[] a = new float[4];
            int i;
            float s=0;
            Console.Write("Ho va ten:");
            ten = Console.ReadLine();
            Console.Write("Lop:");
            lop = Console.ReadLine();
            Console.Write("Diem_QTH:");
            a[0] = float.Parse(Console.ReadLine());
            Console.Write("Diem_HTTTQL:");
            a[1] = float.Parse(Console.ReadLine());
            Console.Write("Diem_CSLT:");
            a[2] = float.Parse(Console.ReadLine());
            Console.Write("Diem_Triet:");
            a[3] = float.Parse(Console.ReadLine());
            for (i=0;i<4;i++)
            {
                if (a[i]>=8.5) {s+=4;}
                else if (a[i]>=7) {s+=3;}
                else if (a[i]>=5) {s+=2;}
                else {s+=1;}
            }
            s/=4;
            if (s>=3.6) {loai="Xuat sac";}
            else if (s>=3.2) {loai="Gioi";}
            else if (s>=2.5) {loai="Kha";}
            else if (s>=2) {loai="Trung binh";}
            else {loai="Yeu";}
            Console.Write("Sinh vien {0}, Lop {1}, Dat GPA {2}, Xep loai {3}",ten.ToUpper(),lop,s,loai);
        }
    }
}

