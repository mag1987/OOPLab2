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
        public bool UserKarmaEnabled { get; set; }
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
            double correction;
            if (UserKarmaEnabled)
                correction = UserVoteWeight(request);
            else correction = 1;
            request.Rateable.RateValue =
                  request.Rateable.RateValue * request.Rateable.Votes / (request.Rateable.Votes + 1)
                  + request.UserRate / (request.Rateable.Votes + 1) * correction;
            request.Rateable.Votes++;
        }
        public RatingSystem()
        {
            UserKarmaEnabled = false;
            UserKarmaLimit = 10;
        }
    }
}
