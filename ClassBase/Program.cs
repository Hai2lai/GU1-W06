internal class Progam
{
    public static void Main(string[] args)
    {
        ShootGun gun = new ShootGun();
        gun.Prog();
        GunMachine gun2 = new GunMachine();
        gun2.Prog();
    }
}

interface Coloring
{

}
interface Resize
{

}
class ColorAnimal
{

}
class Animal:ColorAnimal // lớp cơ sở
{
    public int mat = 2;
    int mieng = 1;
    int chan = 4;

}
class Cat:Animal // lớp dẫn xuất
{
    int khoiLuong = 3;
}
class Dog:Animal // lớp dẫn xuất
{
    int khoiLuong = 4;
}
class DogWhile : Dog , Coloring ,Resize
{
    string mauLong = "mau vang";
}