﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace lab2
{
    public class Top //: IComparable<IRateable>
    {
        public void RequestHandler(Request request)
        {
            if (Rateables.Count < NumberOfTop)
            {
                Rateables.Add(request.Rateable);
                Rateables.Sort();
            }
            else
            {
                if (request.Rateable.RateValue > MinRateable.RateValue)
                {
                    Rateables.Remove(Rateables.Last<IRateable>());
                    Rateables.Add(request.Rateable);
                    Rateables.Sort();
                    MinRateable.RateValue = Rateables.Last<IRateable>().RateValue;
                }
            }
        }
        public int SortByRateLowestFirst(IRateable a, IRateable b)
        {
            if (a.RateValue > b.RateValue) { return 1; }
            else
            {
                if (a.RateValue == b.RateValue) { return 0; }
                else { return -1; }
            }
        }

        public List<IRateable> Rateables = new List<IRateable>();
        public int NumberOfTop { get; set; }
        public IRateable MinRateable { get; set; }
    }
}
