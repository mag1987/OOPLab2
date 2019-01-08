namespace lab2
{
    public class Request
    {
        public IRateable Rateable { get; set; }
        public RatingUser User { get; set; }
        public int UserRate { get; set; }
    }
}
