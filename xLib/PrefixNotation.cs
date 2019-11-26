using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xLib
{
    class PrefixNotation: INotation
    {
        public string arrange(string op, string operand1, string operand2)
        {
            return op + " " + operand1 + " " + operand2;
        }
    }
}
