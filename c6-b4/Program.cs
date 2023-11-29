abstract class RoomForRent
{
    public string tenKH,CMND;
    public int songay;
    public RoomForRent(string tenKH,string CMND,int songay)
    {
        this.tenKH = tenKH;
        this.CMND = CMND;
        this.songay = songay;
    }
    public abstract int Cost();
}
class Standard : RoomForRent
{
    public Standard(string ten,string cmnd,int songaythue) : base(ten,cmnd,songaythue){}
    public override int Cost()
    {
        if (songay<=5) {return songay*500;}
        else {return 400*songay;}
    }
}
class VIP : RoomForRent
{
    public enum RoomType
    {
        Luxury,
        President
    }
    public RoomType loai;
    public VIP(string ten,string cmnd,int songaythue,RoomType loai ) : base(ten,cmnd,songaythue)
    {
        this.loai = loai;
    }
    public override int Cost()
    {
        if (songay<=5)
        {
            if (loai==RoomType.Luxury) {return songay*1100;}
            else {return songay*1300;}
        }
        else {return songay*1000;}
    }
}
class Program
{
    static void Main(string[] args)
    {
        List<RoomForRent> ds = new List<RoomForRent>();
        ds.Add(new Standard("A","1",2));
        ds.Add(new VIP("B","2",2,VIP.RoomType.Luxury));
        ds.Add(new VIP("C","3",6,VIP.RoomType.President));
        ds.Add(new Standard("D","4",6));
        ds.Add(new VIP("E","5",6,VIP.RoomType.Luxury));
        ds.Add(new VIP("F","6",2,VIP.RoomType.President));
        int total = 0,total_L = 0;
        foreach (var i in ds)
        {
            Console.WriteLine($"Ten: {i.tenKH}; CMND: {i.CMND}; So ngay thue: {i.songay}");
            total += i.Cost();
        }
        Console.WriteLine($"Tong tien phong Standard và VIP: {total}");
        foreach (var i in ds)
        {
            if (i is Standard)
            {
                Console.WriteLine($"Ten: {i.tenKH}; CMND: {i.CMND}; So ngay thue: {i.songay}; tien thue: {i.Cost()}");
            }
            if (i is VIP vip && vip.loai==VIP.RoomType.Luxury)
            {
                total_L += i.Cost();
            }
        }
        Console.WriteLine($"Tong tien phong Luxury: {total_L}");
    }
}
