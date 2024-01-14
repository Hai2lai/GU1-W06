using System.Runtime.InteropServices;

class Bullet
{
    bool forward=false;
    public virtual void Prog()
    {
        Console.WriteLine("Vien dan");
    }
}
class ShootGun: Bullet
{
    int number = 40;
    public override void Prog()
    {
        base.Prog();
        Console.WriteLine("shoot gun");
    }
}
class GunMachine : Bullet
{
    int number = 1;
    int speed = 200;
    public override void Prog()
    {
        base.Prog();
        Console.WriteLine("Gun machine");
    }
}
class Gun:Bullet
{
    int number=1;
    int range=10;
}