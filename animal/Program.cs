public class Program
{
    public static void Main(string[] args)
    {
        Cat mycat = new Cat("40","32");
        
    }
}

class Animal
{
    protected string weigh{get;set;}
    protected string height{get;set;}
    public Animal (string weigh,string height)
    {
        this.weigh = weigh;
        this.height = height;
    }
    public virtual void PrintInfor()
    {

    }
}
class Cat : Animal
{
    public Cat(string weigh, string height) : base(weigh, height)
    {

    }
}