using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xLib
{
    class ConstExp : IExpression
    {
        private double value;

        public ConstExp(double value)
        {
            this.value = value;
        }
        public double evaluate(double x)
        {
            return this.value;
        }
        public IExpression derive()
        {
            return new ConstExp(0);
        }

        public string toString(INotation ntn)
        {
            return this.value.ToString();
        }
    }
}
