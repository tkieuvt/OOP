// See https://aka.ms/new-console-template for more information
class tamgiac
{
    double a,b,c;
    public tamgiac()
    {}
    public void nhap()
    {
        Console.WriteLine("3 canh:");
        a = Convert.ToDouble(Console.ReadLine());
        b = Convert.ToDouble(Console.ReadLine());
        c = Convert.ToDouble(Console.ReadLine());
    }
    public void xuat()
    {
        int a = kiemtra();
        switch (a)
        {
            case 0: Console.WriteLine("Khong hop le!!!");break;
            case 1: Console.WriteLine("Tam giac thuong");break;
            case 2: Console.WriteLine("Tam giac deu");break;
            case 3: Console.WriteLine("Tam giac vuong can");break;
            case 4: Console.WriteLine("Tam giac vuong");break;
            case 5: Console.WriteLine("Tam giac can");break;
        }
    }
    public int kiemtra()
    {
        if (a+b>c & a+c>b & b+c>a)
        {
            if (a==b & b==c) {return 2;} //đều
            else if ((a==b & a*a+b*b==c*c)  || (a==c & a*a+c*c==b*b) || (c==b & c*c+b*b==a*a))
                {return 3;} //vuông cân
            else if (a*a+b*b==c*c || a*a+c*c==b*b || c*c+b*b==a*a)
                {return 4;} //vuông
            else if (a==b || a==c || c==b)
                {return 5;} //cân
            return 1; //thường
        }
        else {return 0;} // kp tg
    }
}
class bai3c4
{
    static void Main(string[] args)
    {
        tamgiac tg1 = new tamgiac();
        tg1.nhap();
        tg1.xuat();
    }
}
