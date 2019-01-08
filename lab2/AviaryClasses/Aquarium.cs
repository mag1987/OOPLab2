namespace lab2
{
    public class Aquarium : Aviary
    {
        public int Salinity { get; set; }
        public override int HeatPumpPower()
        {
            return RequiredSpace * Temperature * Salinity;
        }
    }
}
