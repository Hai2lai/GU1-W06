internal class Program
{
    private static void Main(string[] args)
    {
        TinhChuVi tinhChuVi1 = new TinhChuVi();
        Console.WriteLine(tinhChuVi1.tinhchuvi(3,4));
        TinhDienTich tinhDienTich1 = new TinhDienTich();
        Console.WriteLine(tinhDienTich1.tinhdientich(3,5));
    }
}
class HinhChuNhat
{
    public int ChieuDai;
    public int ChieuRong;
}

class TinhChuVi : HinhChuNhat
{   
    public int tinhchuvi(int a, int b)
    {
        ChieuDai = a;
        ChieuRong = b;
        int Cv = (ChieuDai+ChieuRong)*2;
        return Cv;
    }
}

class TinhDienTich : HinhChuNhat
{
    public int tinhdientich(int a,int b)
    {
        ChieuDai = a;
        ChieuRong = b;
        int Dt = ChieuDai*ChieuRong;
        return Dt;
    }
}