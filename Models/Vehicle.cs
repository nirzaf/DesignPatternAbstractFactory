namespace DesignPatternAbstractFactory.Models
{
    public abstract class Vehicle
    {
        internal int capacity;
        public string GetData()
        {
            return GetType().Name;
        }
        public int GetCapacity()
        {
            return capacity;
        }
    }
}
