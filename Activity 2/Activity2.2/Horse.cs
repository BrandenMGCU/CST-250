using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Activity2._2
{
    public class Horse : Animal, IRidable // This will be an extension of the Animal class.
    {
        public void BrushMe()
        {
            Console.WriteLine("I the HORSE need to be brushed!");
        }

        public void SaddleUp()
        {
            Console.WriteLine("If we are going somewhere, you need to saddle up!");
        }

        public override void Sing()
        {
            Console.WriteLine("The Horse's greeting is Neh!");
            base.Sing();
        }
    }
}
