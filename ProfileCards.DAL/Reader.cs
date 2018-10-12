namespace ProfileCards.ProfilesManagement
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using System.Linq.Expressions;

    using Specifications;

    internal interface IReader<TEntity> where TEntity : class
    {
        TResult Get<TResult, TPredicateResult>(
            Expression<Func<TEntity, TPredicateResult>> predicate,
            Func<IQueryable<TEntity>, Expression<Func<TEntity, TPredicateResult>>, TResult> func, ISpecification<TEntity> specification = null);
        
    }

    internal class Reader<TEntity> : IReader<TEntity> where TEntity : class
    {
        private readonly DbSet<TEntity> table;

        public Reader(IFormationContext context)
        {
            var dbcontext = context;
            this.table = dbcontext.Set<TEntity>();
        }

        public TResult Get<TResult, TPredicateResult>(
            Expression<Func<TEntity, TPredicateResult>> predicate,
            Func<IQueryable<TEntity>, Expression<Func<TEntity, TPredicateResult>>, TResult> func,
            ISpecification<TEntity> specification = null)
        {
            IQueryable<TEntity> query = this.table;
            specification = specification ?? new DefaultSpecification<TEntity>();
            specification.Includes.ForEach(spec => query = query.Include(spec));
            return func(query.AsNoTracking(), predicate);
        }
    }
}