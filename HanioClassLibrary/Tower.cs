using System;
using System.Collections.Generic;
using System.Text;

namespace HanoiClassLibrary
{
    public class Tower
    {
        public int numberOfDisks { get; set; }
        public Tower(int n)
        {
            this.numberOfDisks = n;
        }
    }
}
