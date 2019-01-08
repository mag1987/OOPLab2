using System.Collections.Generic;

namespace lab2
{
    public interface IRatingSystem
    {
        void CalculateRate(Request request);
        Queue<Request> Requests { get; set; }
    }
}
