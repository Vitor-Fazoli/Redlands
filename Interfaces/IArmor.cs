namespace Redlands.Interfaces;

public interface IArmor
{
    public int Type { get; set; }
    public string Name { get; set; }
    public int Defense { get; set; }
    public int Durability { get; set; }
}
