using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xLib
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IExpression exp = new DivExp(new ConstExp(0), MonomialExp.createInstance(3, 0));
                //IExpression exp = new DivExp(new MulExp(new ConstExp(10), MonomialExp.createInstance(3,0)),new AddExp(new MulExp(MonomialExp.createInstance(5,2), new ConstExp(4)), MonomialExp.createInstance(3, 2)));
                double eValue = exp.evaluate(3);
                Console.WriteLine("Value:");
                Console.WriteLine("The value of expression when x = 3 : {0}", eValue);
                // ---------------
                Console.WriteLine("\nNotations:");
                INotation infixNtn = new InfixNotation();
                INotation prefixNtn = new PrefixNotation();
                INotation posfixNtn = new PosfixNotation();

                Console.WriteLine("Infix Notation: {0}", exp.toString(infixNtn));

                Console.WriteLine("Prefix Notation: {0}", exp.toString(prefixNtn));

                Console.WriteLine("Posfix Notation: {0}", exp.toString(posfixNtn));

                // ---------------
                Console.WriteLine("\nDerivative with notations:");
                Console.WriteLine("Infix Notation: {0}", exp.derive().toString(infixNtn));

                Console.WriteLine("Prefix Notation: {0}", exp.derive().toString(prefixNtn));

                Console.WriteLine("Posfix Notation: {0}", exp.derive().toString(posfixNtn));
            }
            catch (Exception e)
            {
                Console.WriteLine("Error : {0}", e.Message);
            }
        }
    }
}
