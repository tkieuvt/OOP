// // See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Net;
class doanhnghiep
{
    public string tenDN { get; set; }
    public string MST { get; set; }
    public string diachi { get; set; }
}
class danhSachDN
{
    public static int count = 0;
    doanhnghiep DN = new doanhnghiep();
    public danhSachDN()
    {
        Array.Resize(ref IndexDN.ds,count+1);
        Console.Write("Ten doanh nghiep: ");
        DN.tenDN = Console.ReadLine();
        Console.Write("Ma so thue: ");
        DN.MST= Console.ReadLine();
        Console.Write("Dia chi: ");
        DN.diachi= Console.ReadLine();
        IndexDN.ds[count]=DN.tenDN+" "+DN.MST+" "+DN.diachi;
        count++;   
    }
    public void xuatDS()
    {
        for (int i=0;i<count;i++)
            Console.WriteLine(IndexDN.ds[i]);
    }
}
class IndexDN
{
    public static string [] ds = new string[danhSachDN.count];
    public string this [string ten]
    {
        get 
        {
            for (int i=0;i<danhSachDN.count;i++)
            {
                string[] s = ds[i].Split();
                if (ten==s[0]) {return s[1];}
            }
            return "Khong ton tai";
        }
    }
    public string this [int ma]
    {
        get
        {
            for (int i=0;i<danhSachDN.count;i++)
            {
                string[] s = ds[i].Split();
                if (ma.ToString()==s[1]) {return s[0]+" "+s[2];}
            }
            return "Khong ton tai";
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        danhSachDN dn1 = new danhSachDN();
        danhSachDN dn2 = new danhSachDN();
        IndexDN index = new IndexDN();
        Console.Write("Nhap ten doanh nghiep can tim MST:");
        string ten = Console.ReadLine();
        Console.WriteLine(index[ten]);
        Console.Write("Nhap MST cua doanh nghiep can tim:");
        int ma = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine(index[ma]);
    }
}













// using System;
// using System.Collections.Generic;

// class DoanhNghiep
// {
//     public string TenDN { get; set; }
//     public string MST { get; set; }
//     public string DiaChi { get; set; }

//     public DoanhNghiep(string tenDN, string mst, string diaChi)
//     {
//         TenDN = tenDN;
//         MST = mst;
//         DiaChi = diaChi;
//     }
// }

// class DanhSachDN
// {
//     private Dictionary<string, DoanhNghiep> danhSachDoanhNghiep = new Dictionary<string, DoanhNghiep>();

//     public void NhapDanhSach()
//     {
//         Console.Write("Nhập số lượng doanh nghiệp: ");
//         int soLuongDN = int.Parse(Console.ReadLine());

//         for (int i = 0; i < soLuongDN; i++)
//         {
//             Console.WriteLine($"Nhập thông tin doanh nghiệp {i + 1}:");
//             Console.Write("Tên doanh nghiệp: ");
//             string tenDN = Console.ReadLine();
//             Console.Write("Mã số thuế: ");
//             string mst = Console.ReadLine();
//             Console.Write("Địa chỉ: ");
//             string diaChi = Console.ReadLine();

//             DoanhNghiep dn = new DoanhNghiep(tenDN, mst, diaChi);
//             danhSachDoanhNghiep.Add(mst, dn);
//         }
//     }

//     public void XuatDanhSach()
//     {
//         Console.WriteLine("Danh sách doanh nghiệp:");
//         foreach (var dn in danhSachDoanhNghiep.Values)
//         {
//             Console.WriteLine($"Tên DN: {dn.TenDN}, Mã số thuế: {dn.MST}, Địa chỉ: {dn.DiaChi}");
//         }
//     }

//     public string TimMaSoThueTheoTen(string tenDN)
//     {
//         foreach (var dn in danhSachDoanhNghiep.Values)
//         {
//             if (dn.TenDN == tenDN)
//             {
//                 return dn.MST;
//             }
//         }
//         return null; // Trả về null nếu không tìm thấy
//     }

//     public void TimThongTinTheoMaSoThue(string mst)
//     {
//         if (danhSachDoanhNghiep.ContainsKey(mst))
//         {
//             DoanhNghiep dn = danhSachDoanhNghiep[mst];
//             Console.WriteLine($"Tên DN: {dn.TenDN}, Địa chỉ: {dn.DiaChi}");
//         }
//         else
//         {
//             Console.WriteLine($"Không tìm thấy thông tin doanh nghiệp với Mã số thuế {mst}");
//         }
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         DanhSachDN danhSachDN = new DanhSachDN();

//         danhSachDN.NhapDanhSach();
//         danhSachDN.XuatDanhSach();

//         Console.Write("\nNhập tên doanh nghiệp để tìm Mã số thuế: ");
//         string tenDoanhNghiep = Console.ReadLine();
//         string mst = danhSachDN.TimMaSoThueTheoTen(tenDoanhNghiep);

//         if (mst != null)
//         {
//             Console.WriteLine($"Mã số thuế của doanh nghiệp {tenDoanhNghiep} là {mst}");
//         }
//         else
//         {
//             Console.WriteLine($"Không tìm thấy thông tin doanh nghiệp với tên {tenDoanhNghiep}");
//         }

//         Console.Write("\nNhập Mã số thuế để tìm thông tin doanh nghiệp: ");
//         string mstNhap = Console.ReadLine();
//         danhSachDN.TimThongTinTheoMaSoThue(mstNhap);
//     }
// }
