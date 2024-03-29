﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xLib
{
    class DivExp : BinaryExp
    {
        public DivExp(IExpression ex1, IExpression ex2)
        {
            this.exp1 = ex1;
            this.exp2 = ex2;
        }

        public override IExpression derive()
        {
            return new DivExp(
                new AddExp(
                    new MulExp(this.exp1.derive(), this.exp2), 
                    new MulExp(
                        new ConstExp(-1), 
                        new MulExp(this.exp1, this.exp2.derive()))), 
                new MulExp(this.exp2, this.exp2));
        }

        protected override double doEvaluate(double val1, double val2)
        {
            if (val2 == 0) 
                throw new Exception("Division by zero.");
            return val1 / val2;
        }

        protected override string getOperator()
        {
            return "/";
        }
    }
}
