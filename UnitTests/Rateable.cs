using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab2;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class Rateable : IRateable, IComparable<IRateable>
    {
        public string ClassName { get ; set ; }
        public double RateValue { get ; set ; }
        public int Votes { get ; set ; }
        public List<IRatingUser> Users { get ; set ; }

        int IComparable<IRateable>.CompareTo(IRateable other)
        {
            if (RateValue > other.RateValue) { return -1; }
            else
            {
                if (RateValue == other.RateValue) { return 0; }
                else { return 1; }
            }
        }
    }
}
