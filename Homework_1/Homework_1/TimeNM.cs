using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    public class TimeNM
    {
        public int N { get; set; }
        public int M { get; set; }
        public double Time { get; set; }
        public TimeNM(int n, int m, double time)
        {
            N = n;
            M = m;
            Time = time;
        }
    }
}
