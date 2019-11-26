using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xLib
{
    interface Expression
    {
        public double evalute(double x);
        public Expression derive();
        public string toString(Notation ntn);
    }
}
