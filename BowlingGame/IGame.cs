using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGame
{
    public interface IGame
    {
         void Roll(int i);

        int GetScore();
    }
}
