internal class Program
{
    private static void Main(string[] args)
    {
        Room.Truong();
        Room hs1 = new Room();
        Room hs2 = new Room();
        hs1.ThongTin(32,"Nguyen Van 1");
        hs2.ThongTin(54,"Mai Van 2");
        hs1.Printf();
        hs2.Printf();
    }
}

public class Room
{
    private int q;
    private string w;
    private static string TenTruong = "sds";
    public static void Truong()
    {
        TenTruong = "FPT";
    }
    public void ThongTin(int a, string b)
    {
        q = a;
        w = b;
    }
    public void Printf()
    {
        Console.WriteLine("MSSV: "+q+"\nHo va ten: "+w+"\nCo so truong: "+TenTruong);
    }
}