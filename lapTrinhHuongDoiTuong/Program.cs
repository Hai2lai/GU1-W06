using System.Dynamic;

internal class Program
{
    static private  void Main(string[] args)
    {
        Cat cat1 = new Cat(); // con mèo
        Cat cat2 = new Cat(); // con mèo giống y hệt con mèo ở trên 
        cat2.mauSac="mau do";
        cat1.chieuCao =2;// trong Uniti khong chó sửu dụng cách này 
        cat1.tangChieuCao(); // mà nó sẽ sử dụng cái này
        Console.WriteLine(cat1.mauSac);
        Console.WriteLine(cat2.mauSac);
        Cat.dai = 3; // có static phải làm như này

        ACountBannk acount = new ACountBannk(); 
        acount.NumberId=2; // cho numberId ở ACountBannk = 2;
        int c = acount.NumberId; // cho c = giá trị của numberId;
    }
}
class ACountBannk
{
    private int numberId; // không thể bị thay thế ở bên ngoài trừ khi sử dụng NumberId ở dưới
    public int NumberId
    {
        get =>numberId; // lấy giá trị của numberId ra để dùng
        set =>numberId = value; // thay thế numberId bằng giá trị khác
    }
}
class Cat
{
    public int chieuCao=1;
    public void tangChieuCao()
    {
        chieuCao +=3;
    }
    private int age =1 ; // private là chỉ có thể sửa ở trong class này ở ngoài class không thể sửa
    public string mauSac = "mau vang"; // public có thể chỉnh sửa ở mọi nơi
    public string MauMat = "mau xanh";
    public string RiaMep = "co ria mep";
    public static int dai=2; // khi có static ở trên hàm main mà thay đổi ở dưới này cũng thay đổi luôn
    void An()
    {

    }
    void Nhay()
    {

    }
    public void tangTuoi()
    {
        age+=1;
    }
}
