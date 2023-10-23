// See https://aka.ms/new-console-template for more information
// bài 50đ
class NhaphocTKTH
{
    public string hoten,ngsinh,gtinh,chnganh;
    // public static int[] a = new int[10];
    public void nhap()
    {
        Console.Write("Ho ten la ");
        hoten = Console.ReadLine();
        Console.Write("Ngay sinh la ");
        ngsinh = Console.ReadLine();
        Console.Write("Gioi tinh la ");
        gtinh = Console.ReadLine();
        Console.Write("Chuyen nganh ");
        chnganh = Console.ReadLine();
    }
    public NhaphocTKTH()
    {}
    public NhaphocTKTH(string a,string b,string c,string d)
    {
        hoten = a;
        ngsinh = b;
        gtinh = c;
        chnganh = d;
    }

}
class c2bttl1
{
    static void Main(string[] args)
    {
        List<NhaphocTKTH> nhaphoc = new List<NhaphocTKTH>();
        string stt=" ";
        while (stt =="")
        {
            NhaphocTKTH thongtin = new NhaphocTKTH();

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
