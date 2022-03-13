using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Activity2._2
{
    public class Cow : Animal, IDomesticated, IMilkable// This will be an extension of the Animal class.
    {
        public void FeedingTime()
        {
            // The cow must be fed. 
            Console.WriteLine("It is I the COW and it is Feeding Time!");
        }

        public void FeedMe()
        {
            // The cow must be fed. 
            Console.WriteLine("I the cow am being fed.");
        }

        public void MilkingTime()
        {
            Console.WriteLine("I the COW need to be milked and the milk needs to be stored!");
        }

        public void TouchMe()
        {
            Console.WriteLine("I the cow appreicate being touched");
        }
    }
}
