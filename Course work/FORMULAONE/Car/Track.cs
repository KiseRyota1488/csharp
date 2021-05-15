using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingStaff
{
    public class Track
    {
        public int X;
        public int Y;
        public Nullable<int> carNumber { get; set; } = null;

        public Track(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
