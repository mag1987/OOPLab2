using System.Collections.Generic;

namespace lab2
{
    public class Animal:IContainment
    {
       public int RequiredSpace { get; set; }
        public List<string> Meals = new List<string>(); 
    }
}
