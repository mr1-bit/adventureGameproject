using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adventureGameproject
{
    class Schaling
    {
        public int schale { get; set; }
        public Schaling(int x, int y ) {
            schale = x + y + x * y / 2;
        }
    }
}
