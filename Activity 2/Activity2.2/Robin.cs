using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Activity2._2
{
    public class Robin : Animal // Robin is a nondomesticated animal and will be an extension of the Animal class
    {
        public virtual void Sing()
        {
            Console.WriteLine("Chirp Chirp");
        }
    }
}
