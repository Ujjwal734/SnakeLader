using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLader
{
    public class SnakeLadder
    {
        int playerposition = 0;
        public int DiceRoll()
        {
            Random random = new Random();
            return random.Next(1,7);
        }
    }
}
