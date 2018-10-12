namespace ProfileCards.ProfilesManagement.Translators
{
    using System.Linq;

    using Models;

    internal class PersonToProfileCardTranslator : ITranslator<Person, ProfileCard>
    {

        public ProfileCard From(Person input)
        {
            return new ProfileCard
                       {
                           Id = input.Id,
                           BackgroundImage = input.BackgroundImage,
                           ProfileImage = input.ProfileImage,
                           FirstName = input.FirstName,
                           Site = new Site
                                      {
                                          Name = input.Site.Name,
                                          Url = input.Site.Url
                                      },
                           Info = input.Infoes.Select(info => info.Value).ToArray(),
                           SocialNetwork = input.SocialNetworks.Select(
                               networkSocial => new SocialNetwork
                                                    {
                                                        Name = networkSocial.Name,
                                                        Url = networkSocial.Url
                                                    }).ToArray()
                       };
        }
    }
}