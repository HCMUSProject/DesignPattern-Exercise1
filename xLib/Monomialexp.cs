using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xLib
{
    class MonomialExp: IExpression
    {
        private double a, n;

        protected MonomialExp(double a, double n)
        {
            this.a = a;
            this.n = n;
        }
        public static IExpression createInstance(double a, double n)
        {
            if (a == 0)
                return new ConstExp(0);
            if (n == 0)
                return new ConstExp(a);

            return new MonomialExp(a, n);
        }

        public double evaluate(double x)
        {
            return a * Math.Pow(x, n);
        }

        public IExpression derive()
        {
            return MonomialExp.createInstance(this.a * this.n, this.n - 1);
        }

        public string toString(INotation ntn)
        {
            return a + "x^" + n;
        }
    }
}
