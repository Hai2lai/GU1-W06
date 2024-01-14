internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("nhap kich thuoc");
        Console.Write("chieu rong");
        double Width = double.Parse(Console.ReadLine());
        Console.Write("chieu cao");
        double Height = double.Parse(Console.ReadLine());
        //Rectangle2 myRectangle  = new Rectangle2(Width,Height);
        Rectangle2 myRectangle = new Rectangle2(Width,Height,true);
        myRectangle.printfArea();
        myRectangle.printfPerimeter();
        
    }
}