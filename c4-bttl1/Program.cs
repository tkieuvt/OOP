// See https://aka.ms/new-console-template for more information
using System;
using System.Text.RegularExpressions;
class Sinhvien
{
    string Masv;
    int SOTC;
    double giamtru;
    public string masosv
    {
        get {return Masv;}
        set{Masv = value;}
    }
    public int tinchi
    {
        get {return SOTC;}
        set{SOTC = value;}
    }
    public double giam
    {
        get {return giamtru;}
        set{giamtru = value;}
    }
    public double HocPhiSV
    {
        get {return 450000*SOTC-giamtru*SOTC*450000/100;}
    } 
}
class Qlhp
{
    static void Main(string[] args)
    {
        Sinhvien SV = new Sinhvien();
        SV.masosv = "12345";
        SV.tinchi = 3;
        SV.giam = 5;
        Console.WriteLine("Sinh vien co ma so {0},hoc {1} tin chi, giam tru {2}%, phai dong hoc phi la {3}",SV.masosv,SV.tinchi,SV.giam,SV.HocPhiSV);
    }
}
