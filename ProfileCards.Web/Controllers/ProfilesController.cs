namespace ProfileCards.Web.Controllers
{
    using System.Collections.Generic;
    using System.Web.Http;

    using Core;

    using ProfilesManagement.Models;
    using ProfilesManagement.UseCases;

    [RoutePrefix("api/profiles")]
    public class ProfilesController : ApiController
    {
        [HttpGet]
        [Route]
        public IEnumerable<SimpleCard> Get([FromServices] IGetSimpleCards getSimpleCards)
        {
            var simpleCards = getSimpleCards.Get();
            return simpleCards;
        }

        [HttpGet]
        [Route("{id}")]
        public ProfileCard Get([FromServices] IGetProfilCardByPersonId getProfileCard, int id)
        {
            return getProfileCard.Get(id);
        }
    }
}