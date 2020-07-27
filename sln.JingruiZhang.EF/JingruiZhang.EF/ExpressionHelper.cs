using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace JingruiZhang.EF
{
    /// <summary>
    /// Expression 构造器
    /// </summary>
    public static class ExpressionHelper
    {
        /// <summary>
        /// 最后一步：生成最后的 Lambda 表达式。内部为调用 Expression.Lambda&lt;Func&lt;costmgr_item, bool&gt;&gt; 方法，第二个参数为使用默认的x作为参数
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <param name="totalExpress">在形成 lambda 表达式前，goes to 的右半部分</param>
        /// <returns></returns>
        public static Expression<Func<TModel, bool>> Lambda<TModel>(Expression totalExpress)
            where TModel : class, new()
        {
            var total = Expression.Lambda(totalExpress, ExpressionHelper.DefaultParameter<TModel>());
            return (Expression<Func<TModel, bool>>)total;
        }

        /// <summary>
        /// 第三步：生成 x.Name.Contains("b123")
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <param name="member">调用 SomeProperty 方法得到</param>
        /// <param name="exp">调用 Expression.Constant 方法得到</param>
        /// <returns></returns>
        public static MethodCallExpression PropertyContains<TModel>(MemberExpression member, ConstantExpression exp)
        {
            var containsMExp = Expression.Call(member, typeof(string).GetMethod("Contains"), exp);
            return containsMExp;
        }

        /// <summary>
        /// 第二步：生成 x.Name, x.Age 等属性访问表达式
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <param name="propName"></param>
        /// <returns></returns>
        public static MemberExpression SomeProperty<TModel>(string propName)
            where TModel : class, new()
        {
            var expression = Expression.Property(DefaultParameter<TModel>(), propName);
            return expression;
        }

        /// <summary>
        /// 第一步：生成以“x”为名字的参数表达式（内部使用的静态的私有成员 _DefaultParameter）
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <returns></returns>
        public static ParameterExpression DefaultParameter<TModel>()
            where TModel : class, new()
        {
            if (_DefaultParameter == null)
            {
                _DefaultParameter = Expression.Parameter(typeof(TModel), "x");
            }

            return _DefaultParameter;
        }

        private static ParameterExpression _DefaultParameter = null;
    }
}
