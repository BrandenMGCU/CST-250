using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Activity2._2
{
    public interface IDomesticated
    {
        void TouchMe();
        void FeedMe();

        // This is an interface that is saying anyone that uses me will aslo have these two methods.
    }
}
