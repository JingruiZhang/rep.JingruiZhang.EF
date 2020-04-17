using System;
using System.Collections.Generic;
#if NET45
using System.Data.Entity;
#else
using Microsoft.EntityFrameworkCore;
#endif
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace JingruiZhang.EF
{
    /// <summary>
    /// 数据库上下文帮助类（.netFramework及 .netStandard通用帮助类）
    /// </summary>
    public class ZDbContextHelper
    {
        /// <summary>
        /// 获取 DbSet
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="ctx"></param>
        /// <returns></returns>
        public DbSet<T> GetSet<T>(DbContext ctx)
             where T : class
        {
            return ctx.Set<T>();
        }

        /// <summary>
        /// 将对象添加到数据库上下文
        /// </summary>
        /// <param name="ctx"></param>
        /// <param name="model"></param>
        public void Add<T>(DbContext ctx, T model)
            where T : class
        {
            ctx.Set<T>().Add(model);
        }

        /// <summary>
        /// 将多个对象添加到数据库上下文
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="ctx"></param>
        /// <param name="models"></param>
        public void AddRange<T>(DbContext ctx, List<T> models)
             where T : class
        {
            ctx.Set<T>().AddRange(models);
        }

        /// <summary>
        /// 让数据库上下文追踪实体变化 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="ctx"></param>
        /// <param name="model"></param>
        public void Modify<T>(DbContext ctx, T model)
             where T : class
        {
            ctx.Entry<T>(model).State = EntityState.Modified;
        }

        /// <summary>
        /// 数据库上下文跟踪对象的移除
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="ctx"></param>
        /// <param name="model"></param>
        public void Delete<T>(DbContext ctx, T model)
             where T : class
        {
            ctx.Set<T>().Remove(model);
        }

        /// <summary>
        /// 数据库上下文跟踪多个对象的移除
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="ctx"></param>
        /// <param name="models"></param>
        public void DeleteRange<T>(DbContext ctx, List<T> models)
             where T : class
        {
            ctx.Set<T>().RemoveRange(models);
        }

        /// <summary>
        /// 将实体变化写入数据库
        /// </summary>
        /// <param name="ctx"></param>
        /// <returns></returns>
        public int SaveChanges(DbContext ctx)
        {
            return ctx.SaveChanges();
        }

        /// <summary>
        /// 单表查询带分页方法，单个排序方式
        /// </summary>
        /// <typeparam name="T">表名映射的实体类型</typeparam>
        /// <typeparam name="TProp">排序字段的类型</typeparam>
        /// <param name="ctx">数据库上下文</param>
        /// <param name="where">过滤Lambda</param>
        /// <param name="total">过滤后的总数</param>
        /// <param name="orderBy">排序Lambda</param>
        /// <param name="isAsc">是否为正序</param>
        /// <param name="skip">跳过数目</param>
        /// <param name="take">get数目</param>
        /// <returns></returns>
        public List<T> GetModelList<T, TProp>(DbContext ctx, Expression<Func<T, bool>> where,
         out int total, Expression<Func<T,TProp>> orderBy, bool isAsc, int skip, int take)
         where T : class
        {
            var setq = ctx.Set<T>().Where(where);
            IQueryable<T> seto = null;
            total = setq.Count();
            if (isAsc)
            {
                seto = setq.OrderBy(orderBy);
            }
            else
            {
                seto = setq.OrderByDescending(orderBy);
            }
            var lasto = seto.Skip(skip).Take(take);
            return lasto.ToList();
        }

        /// <summary>
        /// 通用的单表查询带分页方法
        /// </summary>
        /// <typeparam name="T">表名映射的实体类型</typeparam>
        /// <param name="ctx">数据库上下文</param>
        /// <param name="where">过滤Lambda</param>
        /// <param name="total">过滤后的总数</param>
        /// <param name="orderby_isascs">多组排序集合</param>
        /// <param name="skip">跳过数目</param>
        /// <param name="take">get数目</param>
        /// <returns></returns>
        public List<T> GetModelList<T>(DbContext ctx, Expression<Func<T, bool>> where,
            out int total, List<OrderByModel<T>> orderby_isascs, int skip, int take)
            where T : class
        {
            var setq = ctx.Set<T>().Where(where);
            IQueryable<T> seto = null;
            total = setq.Count();
            for (int i = 0; i < orderby_isascs.Count; i++)
            {
                if (orderby_isascs[i].IsAsc)
                {
                    if (seto == null)
                    {
                        seto = setq.OrderBy(orderby_isascs[i].OrderBys);
                    }
                    else
                    {
                        seto = ((IOrderedQueryable<T>)seto).ThenBy(orderby_isascs[i].OrderBys);
                    }
                }
                else
                {
                    if (seto == null)
                    {
                        seto = setq.OrderByDescending(orderby_isascs[i].OrderBys);
                    }
                    else
                    {
                        seto = ((IOrderedQueryable<T>)seto).ThenByDescending(orderby_isascs[i].OrderBys);
                    }
                }
            }
            var lasto = seto.Skip(skip).Take(take);
            return lasto.ToList();
        }

        /// <summary>
        /// 设置 AutoDetectChangesEnabled 属性，仅适用于DotNet45版本
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="ctx"></param>
        /// <param name="auto"></param>
#if NET45

#else
        [Obsolete("DotNetCore版本不支持此项操作")]
#endif
        public void SetAutoDetectChangesEnabled<T>(DbContext ctx, bool auto)
        {
#if NET45
            ctx.Configuration.AutoDetectChangesEnabled = auto;
#else
            
#endif

        }
    }
}
