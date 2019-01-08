namespace lab2
{
    public abstract class Aviary : Container, IContainment
    {
       public int RequiredSpace { get; set; }
        public int Temperature { get; set; }
        public virtual int HeatPumpPower()
        {
            return RequiredSpace * Temperature;
        }
    }
}
