using System.Security.Cryptography.X509Certificates;
class Doanhnghiep
{
    public string tenDN,mst,diachi;
    public Doanhnghiep()
    {
        Console.Write("Ten doanh nghiep:");
        tenDN = Console.ReadLine();
        Console.Write("Ma so thue:");
        mst = Console.ReadLine();
        Console.Write("Dia chi:");
        diachi = Console.ReadLine();
    } 
}
class DanhSachDN
{
    public List<Doanhnghiep> ds_DN ;
    public DanhSachDN()
    {
        ds_DN = new List<Doanhnghiep>();
        Doanhnghiep dn1 = new Doanhnghiep();
        ds_DN.Add(dn1);
        Doanhnghiep dn2 = new Doanhnghiep();
        ds_DN.Add(dn2);
        Doanhnghiep dn3 = new Doanhnghiep();
        ds_DN.Add(dn3);
    }
    public void xuat()
    {
        foreach (var dn in ds_DN)
        {
            Console.WriteLine($"Ten doanh nghiep: {dn.tenDN}, ma so thue: {dn.mst}, dia chi: {dn.diachi}");
        }
    }
    public string TimMST(string ten)
    {
        for (int i=0;i<ds_DN.Count;i++)
        {
            if (ds_DN[i].tenDN==ten) {return ds_DN[i].mst;}
        }
        return "";
    }
    public void TimInfoDNTheoMST(string mast,out string ten,out string dc)
    {
        ten = "";dc = "";
        for (int i=0;i<ds_DN.Count;i++)
        {
            if (ds_DN[i].mst==mast) 
                {
                    ten = ds_DN[i].tenDN;
                    dc = ds_DN[i].diachi;
                }
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        DanhSachDN danhsach = new DanhSachDN();
        Console.WriteLine("DANH SÁCH DOANH NGHIEP");
        danhsach.xuat();
        Console.Write("Nhap ten DN can tim MST:");
        string ten = Console.ReadLine();
        if (danhsach.TimMST(ten)!="") 
            {Console.WriteLine($"Doanh nghiep {ten} co MST la {danhsach.TimMST(ten)}");}
        else {Console.WriteLine($"Khong tim thay MST cua doanh nghiep {ten}");}
        string diaChi="";ten="";
        Console.Write("Nhap MST can tim thong tin:");
        string Mst = Console.ReadLine();
        danhsach.TimInfoDNTheoMST(Mst,out ten,out diaChi);
        if (diaChi!="" & ten!="")
            {Console.WriteLine($"DN co MST {Mst} la {ten}, diachi: {diaChi}");}
        else {Console.WriteLine("Khong tim thay");}
    }
}