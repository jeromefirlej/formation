namespace ProfileCards.ProfilesManagement.UseCases
{
    using System.Linq;

    using Models;

    using Specifications;

    using Translators;

    public interface IGetProfilCardByPersonId
    {
        ProfileCard Get(int id);
    }

    internal class GetProfilCardByPersonId : IGetProfilCardByPersonId
    {
        private readonly IReader<Person> personReader;

        private readonly ITranslator<Person, ProfileCard> personToProfileCardTranslator;

        public GetProfilCardByPersonId(IReader<Person> personReader, ITranslator<Person, ProfileCard> personToProfileCardTranslator)
        {
            this.personReader = personReader;
            this.personToProfileCardTranslator = personToProfileCardTranslator;
        }

        public ProfileCard Get(int id)
        {
            var person = this.personReader.Get(p => p.Id == id, Queryable.SingleOrDefault, new ProfileCardsSpecification());
            return this.personToProfileCardTranslator.From(person);
        }
    }
}