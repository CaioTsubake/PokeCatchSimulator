using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeCatchSymulator
{
    interface ICatchRate
    {
       int determineCatchRate(int maxHP, int currentHP, int targetRate, int ballBonus, int statusBonus);
    }
}
