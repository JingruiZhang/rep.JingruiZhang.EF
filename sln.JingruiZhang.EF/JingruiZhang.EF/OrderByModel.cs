using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace JingruiZhang.EF
{
    public class OrderByModel<TModel>
    {
        public bool IsAsc { get; set; }

        public Expression<Func<TModel, object>> OrderBys { get; set; }
    }
}
