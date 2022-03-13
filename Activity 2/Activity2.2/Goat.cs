using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Activity2._2
{
    public class Goat : Animal, NOTDomesticated, IRidable // This will be an extension of the Animal class.
    {
        public override void Sing()
        {
            Console.WriteLine("La. La. La. I am billy the goat!!");
        }

        public void DONT_TouchMe()
        {
            Console.WriteLine("STAY BACK AND DON'T TOUCH ME!");
        }

        public void GET_AWAY_FROM_ME()
        {
            Console.WriteLine("I TOLD YOU ONCE TO STAY BACK... NOW I'M GOING TO BITE YOU!!!!");
        }

        public void BrushMe()
        {
            Console.WriteLine("I the GOAT DO NOT WANT TO BE BRUSHED!");
        }

        public void SaddleUp()
        {
            Console.WriteLine("I the GOAT DO NOT WANT A SADDLE ON ME!");
        }
    }
}
