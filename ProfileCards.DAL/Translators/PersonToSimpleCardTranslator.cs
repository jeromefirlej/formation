namespace ProfileCards.ProfilesManagement.Translators
{
    using Models;

    internal class PersonToSimpleCardTranslator : ITranslator<Person, SimpleCard>
    {
        public SimpleCard From(Person input)
        {
            return new SimpleCard
                       {
                           Id = input.Id,
                           BackgroundImage = input.BackgroundImage,
                           ProfileImage = input.ProfileImage,
                           FirstName = input.FirstName
                       };
        }
    }
}