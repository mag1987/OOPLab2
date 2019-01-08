namespace lab2
{
    public class RatingSystem //: IRatingSystem
    {
        public event RequestHandler RateUpdated;
        public void RequestHandler(Request request)
        {
            CalculateRate(request);
            RateUpdated.Invoke(request);
        }
        public int UserKarmaLimit { get; set; }
        public  double UserVoteWeight(Request request)
        {
            if (request.User.UserKarma > UserKarmaLimit) return 1.0;
            else
            {
                if (request.User.UserKarma > (request.Rateable.RateValue / request.UserRate))
                {
                    return (double)request.User.UserKarma / UserKarmaLimit;
                }
                else
                    return request.Rateable.RateValue / request.UserRate;
            }
        }
        public  void CalculateRate(Request request)
        {
            request.Rateable.RateValue = request.Rateable.RateValue * request.Rateable.Votes / (request.Rateable.Votes + 1) +
            request.UserRate * UserVoteWeight(request) / (request.Rateable.Votes + 1);
        }
    }
}
