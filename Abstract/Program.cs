internal class Program
{
    private static void Main(string[] args)
    {
        Girl myGirl = new Girl();
        myGirl.Say();
        Boi myBoi = new Boi();
        myBoi.Say();
    }
}
public abstract class Enemy
{
    public abstract void Actack();
    public abstract void Damage();
}

public class Animal : Enemy
{
    public override void Actack()
    {
        Console.WriteLine("cao can xe");
    }
    public override void Damage()
    {
        Console.WriteLine("-2 mau");
    }
}
public class Robot : Enemy
{
    public override void Actack()
    {
        Console.WriteLine("ban sung");
    }
    public override void Damage()
    {
        Console.WriteLine("-5 mau");
    }
}
public class Human:Enemy
{
    public override void Actack()
    {
        Console.WriteLine("chem");
    }
    public override void Damage()
    {
        Console.WriteLine("-23 mau");
    }
}

public abstract class Verhicle
{
    public abstract void Move();
}
public class Car:Verhicle
{
    public override void Move()
    {
        Console.WriteLine("di chuyen 4 banh");
    }
}
public class Bycle:Verhicle
{
    public override void Move()
    {
        Console.WriteLine("di chuyen 2 banh");
    }
}

public class HuMan
{
    public virtual void Say()
    {
        Console.WriteLine("toi la con nguoi");
    }
}
public class Girl:HuMan
{

}
public class Boi:HuMan
{
    public override void Say()
    {
        base.Say();
        Console.WriteLine("toi la con trai");
    }
}