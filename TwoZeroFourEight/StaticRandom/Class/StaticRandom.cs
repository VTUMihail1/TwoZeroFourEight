using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoZeroFourEight.StaticRandom.Class
{
    public class StaticRandom
    {
        public static int RandomInt(int limit)
        {
            Random random = new Random();
            return random.Next(limit);
        }
    }
}
