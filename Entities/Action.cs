namespace Redlands.Entities;

public abstract class Action()
{
    public string? Name;
    public int Damage;
    public int cooldown;
    public int[,]? Blueprint;
}
