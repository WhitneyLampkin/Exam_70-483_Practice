using System;
using System.Linq.Expressions;

namespace Listing2_78_CreatingHelloWorldWithAnExpressionTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BlockExpression blockExpr = Expression.Block(
             Expression.Call(
                null,
                typeof(Console).GetMethod("Write", new Type[] { typeof(string) }),
                Expression.Constant("Hello ")
                ),
             Expression.Call(
                 null,
                 typeof(Console).GetMethod("WriteLine", new Type[] { typeof(string) }),
                 Expression.Constant("World!")
                 )
                );

            Expression.Lambda<Action>(blockExpr).Compile()();
        }
    }
}
