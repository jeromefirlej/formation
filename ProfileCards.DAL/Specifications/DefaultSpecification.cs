namespace ProfileCards.ProfilesManagement.Specifications
{
    using System;
    using System.Linq.Expressions;

    internal sealed class DefaultSpecification<TEntity> : SpecificationBase<TEntity>
    {
        protected internal override void OnAdd(Action<Expression<Func<TEntity, object>>> addAction)
        {
        }
    }
}