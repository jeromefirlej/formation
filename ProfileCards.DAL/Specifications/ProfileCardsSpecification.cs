namespace ProfileCards.ProfilesManagement.Specifications
{
    using System;
    using System.Linq.Expressions;

    internal class ProfileCardsSpecification : SpecificationBase<Person>
    {
        protected internal override void OnAdd(Action<Expression<Func<Person, object>>> add)
        {
            add(person => person.Site);
            add(person => person.Infoes);
            add(person => person.SocialNetworks);
        }
    }
}