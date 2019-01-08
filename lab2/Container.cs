using System.Collections.Generic;

namespace lab2
{
    public class Container : IContainer<IContainment>
    {
        public int AvailableSpace { get; set; }
        public List<IContainment> Content = new List<IContainment>();
        public void Add(IContainment containment)
        {
            if (containment.RequiredSpace <= AvailableSpace)
            {
                Content.Add(containment);
                AvailableSpace -= containment.RequiredSpace;
            }
        }
        public void Remove(IContainment containment)
        {
            if (Content.Remove(containment) == true)
            {
                AvailableSpace += containment.RequiredSpace;
            }
        }
    }
}
