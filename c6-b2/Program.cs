interface Thietbi
{
    void On(); void Off();
}
class Mayquat : Thietbi
{
    public void On()
    {
        Console.WriteLine("May quat dang bat");
    }
    public void Off()
    {
        Console.WriteLine("May quat dang tat");
    }
}
class Dieuhoa : Thietbi
{
    public void On()
    {
        Console.WriteLine("Dieu hoa dang bat");
    }
    public void Off()
    {
        Console.WriteLine("Dieu hoa dang tat");
    }
}
class Tivi : Thietbi
{
    public void On()
    {
        Console.WriteLine("Tivi dang bat");
    }
    public void Off()
    {
        Console.WriteLine("Tivi dang tat");
    }
}
class Program
{
    static void Main(string [] args)
    {
        Mayquat q = new Mayquat();
        Dieuhoa d = new Dieuhoa();
        Tivi t = new Tivi();
        q.On(); d.Off(); t.On();
    }
}