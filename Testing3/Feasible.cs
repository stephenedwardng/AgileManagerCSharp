using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileManager
{
    interface Feasible
    {
        int CalcManDays();
        int DaysUsed();
        bool IsFeasible();
    }
}
