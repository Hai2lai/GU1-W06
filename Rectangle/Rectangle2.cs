public class Rectangle2
{
    double width,height;
    public Rectangle2(double width , double height , bool change)
    {
        if(change)
        {
            this.width = width/2;
            this.height = height/2;
        }
    }
    public Rectangle2(double Width , double Height)
    {
        this.width=Width;
        this.height=Height;
    }
    public void printfArea()
    {
        Console.WriteLine("dien tich la "+ this.width*this.height);
    }
    public void printfPerimeter()
    {
        Console.WriteLine("chu vi la "+ (this.width+this.height)*2);
    }
}