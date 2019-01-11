﻿using System;
using System.Collections.Generic;

namespace lab2
{
    public class Animal:IContainment,IRateable
    {
        public int RequiredSpace { get; set; }
        public string ClassName { get; set; }
        public double RateValue { get; set; }
        public int Votes { get; set; }
        List<IRatingUser> IRateable.Users { get; set; }

        public List<string> Meals = new List<string>();

        int IComparable<IRateable>.CompareTo(IRateable other)
        {
            throw new NotImplementedException();
        }
    }
}
