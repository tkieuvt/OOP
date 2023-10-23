// See https://aka.ms/new-console-template for more information
using System;
using System.Diagnostics.Contracts;
class info
{
    public static int count=0;
    public string id { get; set; }
    public string hoten { get; set; }
    public string group { get; set; }

    public info()
    {
        Console.Write("Ma sinh vien: ");
        id = Console.ReadLine();
        Console.Write("Ho ten sinh vien: ");
        hoten = Console.ReadLine();
        Console.Write("Lop SH: ");
        group = Console.ReadLine();
        DiemTP diem = new DiemTP();
        count++;
    }
    public void xuat()
    {
        Console.Write("MSV: {0}, ho ten: {1},lop:{2},diem:{3}",id,hoten,group,diem.DiemTB());
    }
}
class DiemTP
{ 
    public double TP1 { get; set; }
    public double TP2 { get; set; }
    public double TP3 { get; set; }
    public DiemTP()
    {
        Console.Write("Nhap diem TP1: ");
        TP1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nhap diem TP2: ");
        TP2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nhap diem TP3: ");
        TP3 = Convert.ToDouble(Console.ReadLine());        
    }
    public double DiemTB()
    {
        return TP1*0.1+TP2*0.3+TP3*0.6;
    }
}
class Program
{
    static void Main(string[] args)
    {
        info sv1 = new info();
        info sv2 = new info();
        info sv3 = new info();
        Console.WriteLine("So luong sinh vien trong lop hoc phan OOP là:{0}",info.count);
        foreach (string x in info.ds)
        {
            Console.WriteLine(x);
        }
    }
}

// using System;
// using System.Collections.Generic;
// using System.IO;

// class RealEstate
// {
//     public string MaBDS { get; set; }
//     public string TenBDS { get; set; }
//     public string Huong { get; set; }
//     public string DiaChi { get; set; }
//     public double DienTich { get; set; }
//     public double GiaBan { get; set; }

//     public override string ToString()
//     {
//         return $"MaBDS: {MaBDS}, TenBDS: {TenBDS}, Huong: {Huong}, DiaChi: {DiaChi}, DienTich: {DienTich}, GiaBan: {GiaBan}";
//     }
// }

// class RealEstateList
// {
//     private List<RealEstate> danhSachBDS;

//     public RealEstateList()
//     {
//         danhSachBDS = new List<RealEstate>();
//     }

//     public void NhapTuFile(string filePath)
//     {
//         // Viết mã để nhập danh sách Bất động sản từ file (.txt hoặc .xlsx)
//         // Sử dụng thư viện để đọc file, ví dụ: File.ReadAllText() hoặc thư viện đọc Excel
//     }

//     public void ThemMoiBDS(RealEstate bds)
//     {
//         danhSachBDS.Add(bds);
//     }

//     public void SuaThongTinBDS(string maBDS)
//     {
//         // Viết mã để sửa thông tin Bất động sản theo mã
//         RealEstate bdsCanSua = TimBDSTheoMa(maBDS);
//         if (bdsCanSua != null)
//         {
//             // Cho phép người dùng nhập các thông tin mới
//             // Ví dụ: Console.ReadLine() để nhập từ bàn phím
//         }
//         else
//         {
//             Console.WriteLine("Không tìm thấy BĐS có mã " + maBDS);
//         }
//     }

//     public void XoaBDS(string maBDS)
//     {
//         // Viết mã để xóa Bất động sản theo mã
//         RealEstate bdsCanXoa = TimBDSTheoMa(maBDS);
//         if (bdsCanXoa != null)
//         {
//             danhSachBDS.Remove(bdsCanXoa);
//             Console.WriteLine("Đã xóa BĐS có mã " + maBDS);
//         }
//         else
//         {
//             Console.WriteLine("Không tìm thấy BĐS có mã " + maBDS);
//         }
//     }

//     public void XuatDanhSach()
//     {
//         // Viết mã để xuất danh sách Bất động sản
//         foreach (RealEstate bds in danhSachBDS)
//         {
//             Console.WriteLine(bds.ToString());
//         }
//     }

//     public void TimTheoTen(string ten)
//     {
//         // Viết mã để tìm Bất động sản theo tên và hiển thị đầy đủ thông tin
//         foreach (RealEstate bds in danhSachBDS)
//         {
//             if (bds.TenBDS.ToLower().Contains(ten.ToLower()))
//             {
//                 Console.WriteLine(bds.ToString());
//             }
//         }
//     }

//     public void TimTheoHuong(string huong)
//     {
//         // Viết mã để tìm Bất động sản theo hướng và hiển thị đầy đủ thông tin
//         foreach (RealEstate bds in danhSachBDS)
//         {
//             if (bds.Huong.ToLower() == huong.ToLower())
//             {
//                 Console.WriteLine(bds.ToString());
//             }
//         }
//     }

//     public void TimTheoGia(double giaMin, double giaMax)
//     {
//         // Viết mã để tìm Bất động sản theo khoảng giá và sắp xếp theo giá tăng dần
//         List<RealEstate> ketQua = new List<RealEstate>();
//         foreach (RealEstate bds in danhSachBDS)
//         {
//             if (bds.GiaBan >= giaMin && bds.GiaBan <= giaMax)
//             {
//                 ketQua.Add(bds);
//             }
//         }

//         ketQua.Sort((x, y) => x.GiaBan.CompareTo(y.GiaBan));

//         foreach (RealEstate bds in ketQua)
//         {
//             Console.WriteLine(bds.ToString());
//         }
//     }

//     private RealEstate TimBDSTheoMa(string maBDS)
//     {
//         // Viết mã để tìm Bất động sản theo mã
//         return danhSachBDS.Find(bds => bds.MaBDS == maBDS);
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         RealEstateList danhSachBDS = new RealEstateList();

//         int choice;
//         do
//         {
//             Console.WriteLine("Menu:");
//             Console.WriteLine("1: Thêm mới danh sách");
//             Console.WriteLine("2: Sửa thông tin");
//             Console.WriteLine("3: Xóa thông tin");
//             Console.WriteLine("4: Xuất danh sách");
//             Console.WriteLine("5: Tìm theo Tên");
//             Console.WriteLine("6: Tìm theo Hướng");
//             Console.WriteLine("7: Tìm theo Giá");
//             Console.WriteLine("0: Exit");

//             Console.Write("Nhập lựa chọn của bạn: ");
//             choice = int.Parse(Console.ReadLine());

//             switch (choice)
//             {
//                 case 1:
//                     Console.Write("Nhập đường dẫn file (.txt hoặc .xlsx): ");
//                     string filePath = Console.ReadLine();
//                     danhSachBDS.NhapTuFile(filePath);
//                     break;
//                 case 2:
//                     Console.Write("Nhập mã Bất động sản cần sửa: ");
//                     string maSua = Console.ReadLine();
//                     danhSachBDS.SuaThongTinBDS(maSua);
//                     break;
//                 case 3:
//                     Console.Write("Nhập mã Bất động sản cần xóa: ");
//                     string maXoa = Console.ReadLine();
//                     danhSachBDS.XoaBDS(maXoa);
//                     break;
//                 case 4:
//                     danhSachBDS.XuatDanhSach();
//                     break;
//                 case 5:
//                     Console.Write("Nhập tên Bất động sản cần tìm: ");
//                     string tenCanTim = Console.ReadLine();
//                     danhSachBDS.TimTheoTen(tenCanTim);
//                     break;
//                 case 6:
//                     Console.Write("Nhập hướng cần tìm: ");
//                     string huongCanTim = Console.ReadLine();
//                     danhSach
