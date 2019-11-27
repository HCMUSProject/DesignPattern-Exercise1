using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xLib
{
    abstract class BinaryExp: IExpression
    {
        protected IExpression exp1, exp2;

        //protected BinaryExp(IExpression e1, IExpression e2)
        //{
        //    this.exp1 = e1;
        //    this.exp2 = e2;
        //}

        public double evaluate(double x)
        {
            double val1 = this.exp1.evaluate(x);
            double val2 = this.exp2.evaluate(x);
            return this.doEvaluate(val1, val2);
        }

        public abstract IExpression derive();

        public string toString(INotation ntn)
        {
            return ntn.arrange(this.getOperator(), this.exp1.toString(ntn), this.exp2.toString(ntn));
        }

        protected abstract double doEvaluate(double val1, double val2);

        protected abstract string getOperator();
    }
}
