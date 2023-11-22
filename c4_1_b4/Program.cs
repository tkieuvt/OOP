using System;
using System.Collections;
using System.IO;
using System.Text;
using System.Runtime.Versioning;
using System.Collections.Generic;
using System.Reflection.Metadata;
namespace BANHANG
{
    class Shop
    {
        string MaSP, TenSP, Phanloai;
        int Tonkho, Giaban;
        public string maSP {get {return MaSP;}set{ MaSP=value;}}
        public string tenSP {get {return TenSP;}set{ TenSP=value;}}
        public int tonkho {get {return Tonkho;}set{ Tonkho=value;}}
        public string phanloai {get {return Phanloai;}set{ Phanloai=value;}}
        public int giaban {get {return Giaban;}set{ Giaban=value;}}
    }
    class QuanLyShop
    {
        public List<Shop> shop = new List<Shop>();
        public void nhapDS()
        {
            string input=File.ReadAllText(@"shop.txt");
            foreach (var row in input.Split("\n"))
            {
                string [] res = new string[5]; 
                int j=0;
                foreach (var col in row.Trim().Split(";"))
                {
                    res[j]=col.Trim();
                    j++;
                }
                Shop sp = new Shop();
                sp.maSP = res[0];
                sp.tenSP= res[1];
                sp.tonkho=Convert.ToInt32(res[2]);
                sp.phanloai= res[3];
                sp.giaban=Convert.ToInt32(res[4]);
                shop.Add(sp);
            }
        }
        public void xuatDS()
        {
            foreach (var ds in shop)
            {
                Console.WriteLine($"{ds.maSP} ; {ds.tenSP} ; {ds.tonkho} ; {ds.phanloai} ; {ds.giaban} ");
            }
        }
        public void cap_nhat()
        {
            Console.Write("Nhap ma san pham can cap nhat thong tin: ");
            string ma=Console.ReadLine();
            int t=0;
            foreach (var ds in shop)
            {
                if (ds.maSP==ma) 
                {
                    t=1;
                    Console.Write("So luong: ");
                    int sl =Convert.ToInt32(Console.ReadLine());
                    ds.tonkho=sl;
                    Console.Write("Gia ban: ");
                    int gb =Convert.ToInt32(Console.ReadLine());
                    ds.giaban=gb;
                    break;
                }
            }
            if (t==0) {Console.WriteLine("Khong tim thay ma san pham");}
            else {xuatDS();}
        }
        public void thong_ke()
        {
            foreach (var ds in shop)
            {
                if (ds.tonkho<=10) 
                {
                    Console.WriteLine($"{ds.maSP} ; {ds.tenSP} ; {ds.tonkho} ; {ds.phanloai} ; {ds.giaban} ");
                }
            }
        }
        public void mua_hang()
        {
            Console.WriteLine("Nhap thong tin san pham can mua");
            int j=0,t=0,s=0,t1=0;
            while (true)
            {
                t=0;
                Console.Write("Ma san pham: ");
                string ma =Console.ReadLine();
                foreach (var ds in shop)
                {
                    if (ds.maSP==ma)
                    {
                        t=1;
                        Console.Write("So luong: ");
                        int sl =Convert.ToInt32(Console.ReadLine());
                        if (ds.tonkho<sl) {Console.WriteLine("Không hợp lệ");break;}
                        else {s+=sl*ds.giaban;ds.tonkho-=sl;}
                    }
                }
                if (t==0) {Console.WriteLine("Không hợp lệ");}
                if (t==1)
                {
                    Console.WriteLine("Nhan 1 de mua them; nhan 0 de ket thuc");
                    t1=Convert.ToInt32(Console.ReadLine());
                    if (t1==0) {Console.WriteLine($"Số tiền cần phải trả cho hóa đơn là {s}");break;}
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding=Encoding.Unicode;
            Console.OutputEncoding=Encoding.Unicode;
            QuanLyShop quanly = new QuanLyShop();
            quanly.nhapDS();
            while (true)
            {
                Console.WriteLine("------MENU------\nChon so theo yeu cau");
                Console.WriteLine("#1. CAP NHAT (so luong, gia ban)");
                Console.WriteLine("#2. THONG KE (san pham co ton kho<=10)");
                Console.WriteLine("#3. MUA HANG (dua tren ma san pham và so luong)");
                Console.WriteLine("#0. EXIT");
                Console.Write("Vui long chon yeu cau:");
                int number = Convert.ToInt16(Console.ReadLine());
                if (number==1)
                {
                    Console.WriteLine("--CAP NHAT THONG TIN SAN PHAM--");
                    quanly.cap_nhat();
                }
                else if (number==2)
                {
                    Console.WriteLine("--THONG KE SAN PHAM--");
                    quanly.thong_ke();
                }
                else if (number==3)
                {
                    Console.WriteLine("--MUA HANG--");
                    quanly.mua_hang();
                }
                else if (number==0)
                {
                    Console.WriteLine("---KET THUC CHUONG TRINH---");
                    break;
                }
            }
        }
    }
}