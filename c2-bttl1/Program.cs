using System.Security.Cryptography;
class NhaphocTKTH
{
    public string hoten,ngaysinh,gioitinh,chuyennganh;
    public NhaphocTKTH(string hoten,string ngaysinh,string gioitinh,string chuyennganh)
    {
        this.hoten=hoten;
        this.ngaysinh=ngaysinh;
        this.gioitinh=gioitinh;
        this.chuyennganh=chuyennganh;
    }
    public List<NhaphocTKTH> ds;
    public NhaphocTKTH()
    {
        ds = new List<NhaphocTKTH>();
        NhaphocTKTH sv1 = new NhaphocTKTH("1","1","Nam","TK");
        ds.Add(sv1);
        NhaphocTKTH sv2 = new NhaphocTKTH("2","2","Nu","QTHTTT");
        ds.Add(sv2);
        NhaphocTKTH sv3 = new NhaphocTKTH("3","3","Nam","THQL");
        ds.Add(sv3);
        NhaphocTKTH sv4 = new NhaphocTKTH("4","4","Nu","TK");
        ds.Add(sv4);
        NhaphocTKTH sv5 = new NhaphocTKTH("5","5","Nam","QTHTTT");
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
    }

    public void xuat()
    {
        foreach (var sv in ds)
        {Console.WriteLine($"Ho ten: {sv.hoten}, ngay sinh: {sv.ngaysinh}, gioitinh: {sv.gioitinh}, chuyen nganh: {sv.chuyennganh}");}
    }
    public void locSV(string ten)
    {
        int dem=0;
        for (int i=0;i<ds.Count;i++)
        {   
            if (ds[i].chuyennganh==ten)
            {
                dem++;
                Console.WriteLine($"Ho ten: {ds[i].hoten}, ngay sinh: {ds[i].ngaysinh}, gioitinh: {ds[i].gioitinh}, chuyen nganh: {ds[i].chuyennganh}");
            }      
        }
        Console.WriteLine($"So luong sinh vien chuyen nganh {ten} la {dem}\n");  
    }
    public void thongke(string nganh,out int nam,out int nu)
    {
        nam = 0; nu = 0;
        for (int i=0;i<ds.Count;i++)
        {
            if (ds[i].chuyennganh==nganh)
            {
                if (ds[i].gioitinh=="Nam") {nam++;}
                else {nu++;}
            }
        }
    }
}
class c2bttl1
{
    static void Main(string[] args)
    {
        NhaphocTKTH a = new NhaphocTKTH();
        a.xuat();
        int nam=0,nu=0;
        a.thongke("TK",out nam,out nu);
        Console.WriteLine("DANH SACH SINH VIEN THEO TUNG NGANH TRONG KHOA THONG KE TIN HOC");
        a.locSV("TK");
        a.locSV("QTHTTT");
        a.locSV("THQL");
        Console.WriteLine("SO LUONG SINH VIEN NAM/NU THEO TUNG CHUYEN NGANH");
        Console.WriteLine($"So luong sinh vien chuyen nganh Thong Ke là Nam: {nam}, Nu: {nu}");
        a.thongke("QTHTTT",out nam,out nu);
        Console.WriteLine($"So luong sinh vien chuyen nganh Quan tri HTTT là Nam: {nam}, Nu: {nu}");
        a.thongke("THQL",out nam,out nu);
        Console.WriteLine($"So luong sinh vien chuyen nganh THQL là Nam: {nam}, Nu: {nu}");
    }
}
 
