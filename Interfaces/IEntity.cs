namespace Redlands.Interfaces {
    public interface IEntity {
        public int Life { get; set; }
        public int LifeMax { get; set; }    
        public bool Damageable { get; set; }
    }
}