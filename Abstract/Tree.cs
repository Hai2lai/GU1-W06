public class Tree
{
    public virtual void Get()
    {

    }
}
public class Trree:Tree
{
    public override void Get()
    {
        base.Get();
    }
}
public class Ice:Tree
{
    public sealed override void Get() // sealed sẽ không cho nhưng lớp tiếp theo không thể kế thừa nữa 
    {
        base.Get();
    }
}
public class BlackIce:Ice
{
    //not Get();
}