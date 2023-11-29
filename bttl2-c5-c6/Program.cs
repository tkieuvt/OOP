class Basic
{
    public string ID; public double Area,Price; public int Floor;
    public Basic(string ID,double Area,int Floor,double Price)
    {
        this.ID = ID;this.Area = Area;
        this.Floor = Floor;this.Price = Price;
    }
    public void Cost()
    {
        Price = 10*Area;
    }
    public void Xuat()
    {
        Console.WriteLine($"ID: {ID}; dien tich: {Area}; tang: {Floor}; Gia: {Price}");
    }
}
class Condo : Basic
{
    public string View;
    public Condo(string ID,double Area,int Floor,double Price,string View) : base(ID,Area,Floor,Price)
    {
        this.View = View;
    }
    public new void Cost()
    {
        Price = 20*Area;
        if (View=="Bien") {Price *= 1.4; }
        else if (View=="Ho boi") {Price *= 1.1; }
        else if (View=="Thanh pho") {Price *= 1.2; }
    }
    public new void Xuat()
    {
        Console.WriteLine($"ID: {ID}; dien tich: {Area}; tang: {Floor}; Gia: {Price}; huong: {View}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        // List<Basic> ds = new List<Basic>();
        double maxx = 0; string index = "";
        Basic b1 = new Basic("1",3,2,0);b1.Cost();b1.Xuat();
        Basic b2 = new Basic("2",2.5,3,0);b2.Cost();b2.Xuat();
        Basic b3 = new Basic("3",1.5,4,0);b3.Cost();b3.Xuat();
        Condo c1 = new Condo("4",3.5,2,0,"Bien");c1.Cost();c1.Xuat();
        Condo c2 = new Condo("5",4,3,0,"Ho boi");c2.Cost();c2.Xuat();
        Condo c3 = new Condo("6",3.2,4,0,"Thanh pho");c3.Cost();c3.Xuat();
        Condo c4 = new Condo("7",3,2,0,"Bien");c4.Cost();c4.Xuat();
        maxx = b1.Price; index = b1.ID;
        if (maxx<b2.Price) {maxx = b2.Price;index = b2.ID;}
        if (maxx<b3.Price) {maxx = b3.Price;index = b3.ID;}
        if (maxx<c1.Price) {maxx = c1.Price;index = c1.ID;}
        if (maxx<c2.Price) {maxx = c2.Price;index = c2.ID;}
        if (maxx<c3.Price) {maxx = c3.Price;index = c3.ID;}
        if (maxx<c4.Price) {maxx = c4.Price;index = c4.ID;}
        Console.WriteLine($"Can ho gia cao nhat voi ID: {index}; gia: {maxx}");
        // ds.Add(b1);ds.Add(b2);ds.Add(b3);ds.Add(c1);ds.Add(c2);ds.Add(c3);ds.Add(c4);
        // foreach (var i in ds) {i.Xuat();}

    }
}
// thi gồm kế thừa và đa hình, khởi tạo đối tượng có đối số ,75 phút

