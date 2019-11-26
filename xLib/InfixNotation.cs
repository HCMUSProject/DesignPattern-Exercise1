using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xLib
{
    class InfixNotation: INotation
    {
        public string arrange(string op, string operand1, string operand2)
        {
            return "(" + operand1 + " " + op + " " + operand2 + ")";
        }
    }
}
