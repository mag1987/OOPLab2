using System;
using System.Collections.Generic;

namespace lab2
{
    public class RatingUser //: IRatingUser
    {
        public string Name { get; set; }
        public int UserKarma { get; set; }
        public HashSet<IRateable> Likes = new HashSet<IRateable>();
        public HashSet<IRateable> Dislikes = new HashSet<IRateable>();
        public HashSet<IRateable> Recommended = new HashSet<IRateable>();
        public event RequestHandler RateRequest;
        public event RecommendingHandler RecommendRequest;
        public void UpdateUserFavourites(Request request)
        {
            if (request.UserRate >= request.Rateable.RateValue)
                request.User.Likes.Add(request.Rateable);
            else
                request.User.Dislikes.Add(request.Rateable);
        }
        public void UserRate(IRateable rateable)
        {
            Request r = new Request
            {
                User = this,
                UserRate = GetUserRate(),
                Rateable = rateable
            };
            RateRequest?.Invoke(r);
        }
        public void UserRate( IRateable rateable, int rate)
        {
            Request r = new Request
            {
                User = this,
                UserRate = rate,
                Rateable = rateable
            };
            RateRequest?.Invoke(r);
        }
        public Request UserRateRequest( IRateable rateable, int rate)
        {
            Request r = new Request
            {
                User = this,
                UserRate = rate,
                Rateable = rateable
            };
            //ref Request rr = ref r;
            RateRequest?.Invoke(r);
            return  r;
        }
        int GetUserRate()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
        public void Recommend(Top top)
        {
            Request r = new Request
            {
                User = this
            };
            RecommendRequest.Invoke(r,top);
        }
    }
}
