﻿using System;
using System.Collections.Generic;

namespace lab2
{
    public class RatingUser //: IRatingUser
    {
        public event RequestHandler RateRequest;
        public event RecommendingHandler RecommendRequest;
        public void UpdateUserFavourites(Request request)
        {
            if (request.UserRate >= request.Rateable.RateValue)
                Likes.Add(request.Rateable);
            else
                Dislikes.Add(request.Rateable);
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
        public void UserRate(IRateable rateable, int rate)
        {
            Request r = new Request
            {
                User = this,
                UserRate = rate,
                Rateable = rateable
            };
            RateRequest?.Invoke(r);
        }
        public Request UserRateRequest(IRateable rateable, int rate)
        {
            Request r = new Request
            {
                User = this,
                UserRate = rate,
                Rateable = rateable
            };
            RateRequest?.Invoke(r);
            return r;
        }
        public int UserKarma { get; set; }
        public List<IRateable> Likes = new List<IRateable>();
        public List<IRateable> Dislikes = new List<IRateable>();
        public List<IRateable> Recommended = new List<IRateable>();
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
