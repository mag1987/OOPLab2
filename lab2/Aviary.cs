using System.Collections.Generic;

namespace lab2
{
    public abstract class Aviary : Container, IContainment, IRateable
    {
        public int RequiredSpace { get; set; }
        public int Temperature { get; set; }
        public string ClassName { get ; set ; }
        public double RateValue { get ; set ; }
        public int Votes { get ; set ; }
        public List<IRatingUser> Users { get ; set ; }

        public int CompareTo(IRateable other)
        {
            if (RateValue > other.RateValue) { return -1; }
            else
            {
                if (RateValue == other.RateValue) { return 0; }
                else { return 1; }
            }
        }
        public virtual int HeatPumpPower()
        {
            return RequiredSpace * Temperature;
        }
    }
}
