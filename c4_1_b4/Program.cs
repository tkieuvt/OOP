public abstract class Room
{
    public string CustomerName { get; set; }
    public string Cmnd { get; set; }
    public int Days { get; set; }

    public abstract double GetPrice();
}
public class StandardRoom : Room
{
    public override double GetPrice()
    {
        return Days < 5 ? 500 : 400;
    }
}
public class VipRoom : Room
{
    public enum RoomType
    {
        Luxury, President
    }

    public RoomType Roomtype { get; set; }

    public override double GetPrice()
    {
        if (Days < 5)
        {
            switch (Roomtype)
            {
                case RoomType.Luxury:
                    return 1100;
                case RoomType.President:
                    return 1300;
            }
        }
        return 1000;
    }
}
class Program
{
    public static void Main(string[] args)
    {
    // Tạo mảng chứa danh sách thông tin thuê phòng
    var rooms = new List<Room>()
    {
        new StandardRoom()
        {
            CustomerName = "Nguyễn Văn A",
            Cmnd = "123456789",
            Days = 4
        },
        new VipRoom()
        {
            CustomerName = "Nguyễn Văn B",
            Cmnd = "987654321",
            Days = 6,
            Roomtype = VipRoom.RoomType.Luxury
        },
        new VipRoom()
        {
            CustomerName = "Nguyễn Văn C",
            Cmnd = "123456789",
            Days = 2,
            Roomtype = VipRoom.RoomType.President
        }
    };

    // Xuất ra tất cả các thông tin thuê phòng (kể cả doanh số tương ứng)
    foreach (var room in rooms)
    {
        Console.WriteLine("{0} - {1} - {2} - {3} - {4}", room.CustomerName, room.Cmnd, room.Days, room.GetPrice(), room.GetPrice() * room.Days);
    }

    // Tính tổng số tiền cho thuê phòng Standard và phòng VIP
    double totalPrice = 0;
    foreach (var room in rooms)
    {
        totalPrice += room.GetPrice() * room.Days;
    }
    Console.WriteLine("Tổng doanh thu: {0}", totalPrice);

    // Xuất tất cả các thông tin liên quan đến việc thuê phòng Standard
    foreach (var room in rooms)
    {
        if (room is StandardRoom)
        {
            Console.WriteLine("{0} - {1} - {2} - {3}", room.CustomerName, room.Cmnd, room.Days, room.GetPrice());
        }
    }

    // Tính tổng số tiền cho thuê phòng Luxury
    double totalPriceLuxury = 0;
    foreach (var room in rooms)
        {
            if (room is VipRoom vipRoom && vipRoom.Roomtype == VipRoom.RoomType.Luxury)
            {
                totalPriceLuxury += vipRoom.GetPrice() * vipRoom.Days;
            }
        }
        Console.WriteLine("Tổng doanh thu phòng Luxury: {0}", totalPriceLuxury);
    }
}

