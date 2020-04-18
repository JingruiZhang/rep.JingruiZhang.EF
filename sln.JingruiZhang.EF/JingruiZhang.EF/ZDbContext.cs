using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
#if NET45
using System.Data.Entity;
#else
using Microsoft.EntityFrameworkCore;
#endif

namespace JingruiZhang.EF
{
    /// <summary>
    /// 使用后记得 Dispose 掉，使用连接字符串进行构造
    /// </summary>
    public class ZDbContext : IDisposable
    {
        /// <summary>
        /// 内部的 DbContext 对象
        /// </summary>
        protected DbContext ctx = null;

        /// <summary>
        /// 使用 DbContext 对象构造 ZDbContext 对象
        /// </summary>
        /// <param name="ctx"></param>
        public ZDbContext(DbContext ctx)
        {
            this.ctx = ctx;
        }

        /// <summary>
        /// Dispose 掉内部的 DbContext
        /// </summary>
        public void Dispose()
        {
            this.ctx.Dispose();
        }

        /// <summary>
        /// 获取 DbSet
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public DbSet<T> GetSet<T>()
             where T : class
        {
            return ctx.Set<T>();
        }

        /// <summary>
        /// 将对象添加到数据库上下文
        /// </summary>
        /// <param name="model"></param>
        public void Add<T>(T model)
            where T : class
        {
            ctx.Set<T>().Add(model);
        }

        /// <summary>
        /// 将多个对象添加到数据库上下文
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="models"></param>
        public void AddRange<T>(List<T> models)
             where T : class
        {
            ctx.Set<T>().AddRange(models);
        }

        /// <summary>
        /// 让数据库上下文追踪实体变化 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="model"></param>
        public void Modify<T>(T model)
             where T : class
        {
            ctx.Entry<T>(model).State = EntityState.Modified;
        }

        /// <summary>
        /// 让数据库上下文追踪多个实体变化
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="models"></param>
        /// <param name="AutoDetectChangesSet">对于core版本，该参数不生效</param>
        public void ModifyRange<T>(List<T> models, bool AutoDetectChangesSet)
            where T:class
        {
#if NET45
            if (AutoDetectChangesSet)
            {
                SetAutoDetectChangesEnabled(false);
            }
#endif
            for (int i = 0; i < models.Count; i++)
            {
                Modify<T>(models[i]);
            }
#if NET45
            if (AutoDetectChangesSet)
            {
                SetAutoDetectChangesEnabled(true);
            }
#endif
        }

        /// <summary>
        /// 数据库上下文跟踪对象的移除
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="model"></param>
        public void Delete<T>(T model)
             where T : class
        {
            ctx.Set<T>().Remove(model);
        }

        /// <summary>
        /// 数据库上下文跟踪多个对象的移除
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="models"></param>
        public void DeleteRange<T>(List<T> models)
             where T : class
        {
            ctx.Set<T>().RemoveRange(models);
        }

        /// <summary>
        /// 将实体变化写入数据库
        /// </summary>
        /// <param name="ctx"></param>
        /// <returns></returns>
        public int SaveChanges()
        {
            return ctx.SaveChanges();
        }

        /// <summary>
        /// 单表查询带分页方法，单个排序方式
        /// </summary>
        /// <typeparam name="T">表名映射的实体类型</typeparam>
        /// <typeparam name="TProp">排序字段的类型</typeparam>
        /// <param name="where">过滤Lambda</param>
        /// <param name="total">过滤后的总数</param>
        /// <param name="orderBy">排序Lambda</param>
        /// <param name="isAsc">是否为正序</param>
        /// <param name="skip">跳过数目</param>
        /// <param name="take">get数目</param>
        /// <returns></returns>
        public List<T> GetModelList<T, TProp>(Expression<Func<T, bool>> where,
         out int total, Expression<Func<T, TProp>> orderBy, bool isAsc, int skip, int take)
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
        /// <param name="where">过滤Lambda</param>
        /// <param name="total">过滤后的总数</param>
        /// <param name="orderby_isascs">多组排序集合</param>
        /// <param name="skip">跳过数目</param>
        /// <param name="take">get数目</param>
        /// <returns></returns>
        public List<T> GetModelList<T>(Expression<Func<T, bool>> where,
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
        /// <param name="auto"></param>
#if NET45

#else
        [Obsolete("DotNetCore版本不支持此项操作")]
#endif
        public void SetAutoDetectChangesEnabled(bool auto)
        {
#if NET45
            ctx.Configuration.AutoDetectChangesEnabled = auto;
#else
            
#endif

        }
    }
}
