namespace Redlands.Interfaces
{
    public interface IProfession
    {
        public string Name { get; }
        public Action[] CollectionActions { get; }

    }
}