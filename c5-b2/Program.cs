using System;
using System.Collections.Generic;

class People
{
    public string ID,Hoten,Tuoi,Diachi;
    public People(){}
    public void nhap()
    {
        Console.Write("ID: ");
        ID = Console.ReadLine();
        Console.Write("Ho ten: ");
        Hoten = Console.ReadLine();
        Console.Write("Tuoi: ");
        Tuoi = Console.ReadLine();
        Console.Write("Diachi: ");
        Diachi = Console.ReadLine();
    }
    public void xuat()
    {
        Console.Write($"ID: {ID}; Ho ten: {Hoten}; Tuoi: {Tuoi}; Diachi: {Diachi}");
    }
}
class Student : People
{
    public string Term;
    public float TP1,TP2,TP3;
    public double gpa;
    public double GPA(float a,float b,float c)
    {
        return Math.Round((a+b+c)/3,2);
    }
    public new void nhap()
    {
        base.nhap();
        Console.Write("Hoc phan: ");
        Term = Console.ReadLine();
        Console.Write("TP1: ");
        TP1 = float.Parse(Console.ReadLine());
        Console.Write("TP2: ");
        TP2 = float.Parse(Console.ReadLine());
        Console.Write("TP3: ");
        TP3 = float.Parse(Console.ReadLine());
        gpa = GPA(TP1,TP2,TP3);
    }
    public new void xuat()
    {
        base.xuat();
        Console.Write($"; TP1: {TP1}; TP2: {TP2}; TP3: {TP3}");
        Console.Write($"; GPA: {gpa}");
    }
}
class Lecture : People
{
    public int Kinhnghiem;
    public string Hocvi,Chucvu;

    public new void nhap()
    {
        base.nhap();
        Console.Write("Nam kinh nghiem: ");
        Kinhnghiem = int.Parse(Console.ReadLine());
        Console.Write("Hoc vi: ");
        Hocvi = Console.ReadLine();
        Console.Write("Chuc vu: ");
        Chucvu = Console.ReadLine();
    }
    // public static void Sapxep(List<Lecture> lecturers)
    // {
    //     lecturers.Sort((x, y) => y.Kinhnghiem.CompareTo(x.Kinhnghiem));
    // }

    public static void sapxep(List<Lecture> L)
    {
        List<int> a = new List<int>();
        foreach (var i in L)
        {
            a.Add(i.Kinhnghiem);
        }
        a.Sort();
        for (int i=1;i<a.Count;i++)
        {
            if (a[i]==a[i-1])
                {a.RemoveAt(i);
                i--;}
        }
        for (int i=a.Count-1;i>=0;i--)
        {
            foreach (var j in L)
            {
                if (j.Kinhnghiem==a[i])
                    j.xuat();
                    // Console.WriteLine()
            }
        }
    }
    public new void xuat()
    {
        base.xuat();
        Console.WriteLine($"; Kinh nghiem {Kinhnghiem} nam; Hoc vi: {Hocvi}; Chuc vu: {Chucvu}");
    }

}
class Program
{
    static void Main(string[] args)
    {
        // Console.Write("So luong hoc sinh: ");
        // int n = Convert.ToInt32(Console.ReadLine());
        // Student p = new Student();
        // p.nhap();
        // p.xuat();
        List<Lecture> L = new List<Lecture>();
        Console.Write("So luong giang vien: ");
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i=0;i<n;i++)
        {
            Lecture p1 = new Lecture();
            p1.nhap();
            L.Add(p1);
        }
        Lecture.sapxep(L);
    }
}