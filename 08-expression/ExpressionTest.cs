using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _08_expression
{
    /// <summary>
    /// 
    /// 什么是表达式目录树Expression
    /// 
    /// 
    /// 
    /// 动态拼装Expression
    /// 
    /// 
    /// 
    /// 
    /// 基于Expression扩展应用
    /// 
    /// 
    /// 
    /// 
    /// 
    /// </summary>
    public class ExpressionTest
    {

        public static void Test01()
        {
            //委托
            new List<int> { 1, 2, 3 }.Where(i => i > 1);
            //表达式目录树
            new List<int> { 1, 2, 3 }.AsQueryable().Where(i => i > 1);


            //是一个方法，是实例化委托的参数
            Func<int, int, int> func = (m, n) => m + n;


            //是一个数据结构
            //不能是语句体，只能是一行
            //exp.Compile()之后就是一个委托
            Expression<Func<int,int,int>> exp = (m, n) => m + n;

            Func<int,int,int> func1 = exp.Compile();

            int a = exp.Compile().Invoke(1, 2);

            Console.WriteLine(a);

            {

                Expression<Func<int>> expression = () =>  1 + 2 ;

                Expression<Func<int>> exp1 = Expression.Lambda<Func<int>>(Expression.Constant(3, typeof(int)), new ParameterExpression[0]);

                int iResult = expression.Compile().Invoke();

                
            }

            {
                Expression<Func<int>> expression;

                Expression exp1 = Expression.Constant(1);
                Expression exp2 = Expression.Constant(2);

                Expression exp3 = Expression.Add(exp1, exp2);

                expression = Expression.Lambda<Func<int>>(exp3);

                int iResult = expression.Compile().Invoke();

                Console.WriteLine(iResult);

            }

        }

        public static void Test02()
        {

            Student vo = ExpressionMapper.Trans<VoStudent, Student>(new VoStudent
            {
                Id = 1,
                UserName = "Json",
                Password = "123456"
            });

            Console.WriteLine(vo);
        }



    }
}
