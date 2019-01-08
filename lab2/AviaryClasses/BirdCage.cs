namespace lab2
{
    public class BirdCage : Aviary
    {
        public int Height { get; set; }
        public override int HeatPumpPower()
        {
            return (RequiredSpace+Height) * Temperature;
        }
    }
}
