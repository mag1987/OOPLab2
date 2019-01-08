using System;
using System.Collections.Generic;

namespace lab2
{
    public interface IRateable :IComparable<IRateable>
    {
        string ClassName { get; set; }
        double RateValue { get; set; }
        int Votes { get; set; }
        List<IRatingUser> Users { get; set; }
    }
}
