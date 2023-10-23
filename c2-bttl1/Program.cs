// See https://aka.ms/new-console-template for more information
// bài 50đ

class NhaphocTKTH
{
    public string hoten,ngaysinh,gioitinh,chuyennganh;
    public NhaphocTKTH(string hoten,string ngaysinh,string gioitinh,string chuyennganh)
    {
        this.hoten=hoten;
        this.ngaysinh=ngaysinh;
        this.gioitinh=gioitinh;
        this.chuyennganh=chuyennganh;
        // Console.Write("Ho ten la ");
        // hoten = Console.ReadLine();
        // Console.Write("Ngay sinh la ");
        // ngaysinh = Console.ReadLine();
        // Console.Write("Gioi tinh la ");
        // gioitinh = Console.ReadLine();
        // Console.Write("Chuyen nganh ");
        // chuyennganh = Console.ReadLine();
    }
    public void xuat()
    {
        Console.WriteLine($"Ho ten: {hoten}, ngay sinh: {ngaysinh}, gioitinh: {gioitinh}, chuyen nganh: {chuyennganh}");
    }
    // public void locSV()
    // {

    // }
}
class c2bttl1
{
    static void Main(string[] args)
    {
        List<NhaphocTKTH> ds = new List<NhaphocTKTH>();
        NhaphocTKTH sv1 = new NhaphocTKTH("1","1","Nam","TK");
        ds.Add(sv1);
        NhaphocTKTH sv2 = new NhaphocTKTH("2","2","Nu","QTHTTT");
        ds.Add(sv2);
        NhaphocTKTH sv3 = new NhaphocTKTH("3","3","Nam","THQL");
        ds.Add(sv3);
        NhaphocTKTH sv4 = new NhaphocTKTH("4","4","Nu","TK");
        ds.Add(sv4);
        NhaphocTKTH sv5 = new NhaphocTKTH("5","5","Nam","QTHTTH");
        ds.Add(sv5);
        NhaphocTKTH sv6 = new NhaphocTKTH("6","6","Nu","THQL");
        ds.Add(sv6);
        NhaphocTKTH sv7 = new NhaphocTKTH("7","7","Nam","TK");
        ds.Add(sv7);
        NhaphocTKTH sv8 = new NhaphocTKTH("8","8","Nu","QTHTTT");
        ds.Add(sv8);
        NhaphocTKTH sv9 = new NhaphocTKTH("9","9","Nam","THQL");
        ds.Add(sv9);
        NhaphocTKTH sv10 = new NhaphocTKTH("10","10","Nu","TK");
        ds.Add(sv10);
        for (int i=0;i<ds.Count;i++)
        {
            ds[i].xuat();
        }
    }
}
// class Program
// {
//     static void Main()
//     {
//         List<info> danhSachSinhVien = new List<info>();

//         Console.Write("Nhập số lượng sinh viên: ");
//         int soLuongSinhVien = Convert.ToInt32(Console.ReadLine());

//         // Nhập thông tin sinh viên
//         for (int i = 0; i < soLuongSinhVien; i++)
//         {
//             info sinhVien = NhapThongTinSinhVien();
//             danhSachSinhVien.Add(sinhVien);
//         }

//         // Xuất số lượng sinh viên
//         XuatSoLuongSinhVien(danhSachSinhVien);

//         // Nhập điểm thành phần và xuất thông tin sinh viên
//         foreach (info sinhVien in danhSachSinhVien)
//         {
//             DiemTP diemThanhPhan = NhapDiemThanhPhan();
//             double diemTrungBinh = TinhDiemTrungBinh(diemThanhPhan);
//             XuatThongTinVaDiem(sinhVien, diemTrungBinh);
//             Console.WriteLine();
//         }
//     }

//     static info NhapThongTinSinhVien()
//     {
//         Console.Write("Nhập mã sinh viên: ");
//         string maSinhVien = Console.ReadLine();

//         Console.Write("Nhập họ và tên sinh viên: ");
//         string hoTen = Console.ReadLine();

//         Console.Write("Nhập lớp sinh hoạt: ");
//         string lop = Console.ReadLine();

//         return new info { id = maSinhVien, hoten = hoTen, group = lop };
//     }

//     static void XuatSoLuongSinhVien(List<info> danhSachSinhVien)
//     {
//         Console.WriteLine($"Số lượng sinh viên trong lớp OOP là: {danhSachSinhVien.Count}");
//     }

//     static DiemTP NhapDiemThanhPhan()
//     {
//         Console.Write("Nhập điểm TP1: ");
//         double tp1 = Convert.ToDouble(Console.ReadLine());

//         Console.Write("Nhập điểm TP2: ");
//         double tp2 = Convert.ToDouble(Console.ReadLine());

//         Console.Write("Nhập điểm TP3: ");
//         double tp3 = Convert.ToDouble(Console.ReadLine());

//         return new DiemTP { TP1 = tp1, TP2 = tp2, TP3 = tp3 };
//     }

//     static double TinhDiemTrungBinh(DiemTP diemThanhPhan)
//     {
//         return diemThanhPhan.TP1 * 0.1 + diemThanhPhan.TP2 * 0.3 + diemThanhPhan.TP3 * 0.6;
//     }

//     static void XuatThongTinVaDiem(info sinhVien, double diemTrungBinh)
//     {
//         Console.WriteLine($"Thông tin sinh viên - Mã SV: {sinhVien.id}, Họ tên: {sinhVien.hoten}, Lớp: {sinhVien.group}");
//         Console.WriteLine($"Điểm trung bình môn OOP: {diemTrungBinh}");
//     }
// }
