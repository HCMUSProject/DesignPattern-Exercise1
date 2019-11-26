using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xLib
{
    interface IExpression
    {
        double evaluate(double x);
        IExpression derive();
        string toString(INotation ntn);
    }
}
