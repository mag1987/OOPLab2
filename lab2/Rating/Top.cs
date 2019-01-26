using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab2
{
    public class Top
    {
        public List<IRateable> Rateables = new List<IRateable>();
        public int NumberOfTop { get; set; }
        public IRateable MinRateable { get; set; }
        public void RequestHandler(Request request)
        {
            if (Rateables.Count < NumberOfTop && Rateables.Contains(request.Rateable) == false)
            {
                Rateables.Add(request.Rateable);
                Rateables.Sort();
                MinRateable = Rateables.Last();
            }
            else
            {
                if (request.Rateable.RateValue > MinRateable.RateValue && Rateables.Contains(request.Rateable) == false)
                {
                    Rateables.Remove(Rateables.Last());
                    Rateables.Add(request.Rateable);
                    Rateables.Sort();
                    MinRateable = Rateables.Last();
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
        public Top()
        {
            NumberOfTop = 5;
        }
        public string  RateablesToString()
        {
            StringBuilder s = new StringBuilder();
            foreach (var animal in Rateables)
            {
                s.Append($"{animal.ClassName} ");
            }
            return s.ToString();
        }
    }
}
