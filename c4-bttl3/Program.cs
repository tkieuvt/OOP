// See https://aka.ms/new-console-template for more information
using System;
class BDS
{
    public string maBDS {get;set;}
    public string tenBDS {get;set;}
    public string huong {get;set;}
    public string diaChi {get;set;}
    public int dienTich {get;set;}
    public float giaBan {get;set;}
}
class danhsachBDS
{

    public void nhap()
    {
        String input=File.ReadAllText(@"D:\hoctap\Ki3\LapTrinhHuongĐoiTuong\baitap\BatDongSan.txt");
        string [] res = new string[6];
        // BDS bds = new BDS();
        foreach(var row in input.Split('\n'))
        {
            res = row.Trim().Split(';');
            for (int i=0;i<6;i++)
            {Console.Write(res[i]);}
            // bds.maBDS = res[0];
            // bds.tenBDS = res[1];
            // bds.huong = res[2];
            // bds.diaChi = res[3];
            // bds.dienTich = res[4];
            // bds.giaBan = res[5].ToString();
        }
    }
}

class Program
{
    static void Main(string [] args)
    {
        danhsachBDS ds = new danhsachBDS();
        ds.nhap();
    }
}