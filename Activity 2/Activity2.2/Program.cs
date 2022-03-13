using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Activity2._2
{
    public class Program
    {
        static void Main(string[] args)
        {
            /* This is the instance of the animal beast class*/
            /*Animal beast = new Animal(); // <-----When the class is abstract we cannot do this

             beast.Talk();
             beast.Greet();
             beast.Sing();
            



            /* This is the instance of the Dog class */
            Dog bowser = new Dog();

            bowser.Talk();
            bowser.Greet();
            bowser.Sing();
            bowser.Fetch("stick"); // Needed to define what it was fetching
            bowser.FeedMe();
            bowser.TouchMe();

            Console.WriteLine("=========================================");


            /* THIS IS THE INSTANCE OF THE ROBIN CLASS */
            Robin red = new Robin();
            red.Talk();
            red.Greet();
            red.Sing();
            //red.Fetch();    // Are not a part of the inheritance from Animal class.
            //red.FeedMe();   // Are not a part of the inheritance from Animal class. 
            //red.TouchMe();  // Are not a part of the inheritance from Animal class.
            Console.WriteLine("=========================================");


            /* This is the instance of the HORSE class*/
            Horse horse = new Horse();
            horse.Talk();
            horse.Greet();
            horse.Sing();
            horse.BrushMe();
            horse.SaddleUp();
            Console.WriteLine("=========================================");


            /* This is the instance of the COW class */
            Cow cow = new Cow();
            cow.TouchMe();
            cow.FeedMe();
            cow.Talk();
            cow.FeedingTime();
            cow.MilkingTime();
            Console.WriteLine("=========================================");

            /* This is the instance of the GOAT class */
            Goat goat = new Goat();
            goat.Sing();
            goat.DONT_TouchMe();
            goat.GET_AWAY_FROM_ME();
            goat.SaddleUp();
            goat.BrushMe();
           

            Console.ReadLine();
        }
    }
}
