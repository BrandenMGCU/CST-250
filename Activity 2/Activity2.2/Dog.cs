using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Activity2._2
{
    public class Dog : Animal, IDomesticated// Dog class will inherate the Animal class
    {
        public Dog()
        {
            Console.WriteLine("Dog constructor. Good puppy.");
        }
        public new void Talk()
        {
            Console.WriteLine("Bark Bark Bark");
        }
        public override void Sing()
        {
            Console.WriteLine("Hooowwwl!");
        }

        public void Fetch(String thing)
        {
            Console.WriteLine("Oh boy. Here is your " + thing + ". Let's do it again!");
        }

        public void TouchMe()
        {
            // Added from the IDomesticated interface
            Console.WriteLine("Please scratch behind my ears and rub my belly.");
        }

        public void FeedMe()
        {

            // Added from the IDomesticated interface
            Console.WriteLine("It is time for dinner. My favorite time of day!!!");
        }
    };
}
