using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Milestone1
{
    public class GameCell
    {
        public int Row { get; set; }
        public int Column { get; set; }
        public bool ItsVisible { get; set; }

        public string users_cell { get; set; }
        
        public bool Live { get; set; }

        public int number_of_neighbors { get; set; }
    }

    public GameCell(int r, int c)
    {
        int Row = r;
        int Column = c;
    }
}

