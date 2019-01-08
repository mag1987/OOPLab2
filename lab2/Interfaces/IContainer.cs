namespace lab2
{
    public interface IContainer<IContainment>
    {
         int AvailableSpace { get; set; }
         void Add(IContainment containment);
         void Remove(IContainment containment);
    }
}
