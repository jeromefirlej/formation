namespace ProfileCards.ProfilesManagement.UseCases
{
    using System.Collections.Generic;
    using System.Linq;

    using Models;

    using Translators;

    public interface IGetSimpleCards
    {
        IList<SimpleCard> Get();
    }

    internal class GetSimpleCards : IGetSimpleCards
    {
        private readonly IReader<Person> personReader;

        private readonly ITranslator<Person, SimpleCard> personToSimpleCardTranslator;

        public GetSimpleCards(IReader<Person> personReader, ITranslator<Person, SimpleCard> personToSimpleCardTranslator)
        {
            this.personReader = personReader;
            this.personToSimpleCardTranslator = personToSimpleCardTranslator;
        }

        public IList<SimpleCard> Get()
        {
            IList<Person> people = this.personReader.Get(p => p, Queryable.Select).ToList();
            return people.Select(this.personToSimpleCardTranslator.From).ToList();
        }
    }
}