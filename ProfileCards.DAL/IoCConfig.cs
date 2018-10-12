using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfileCards.ProfilesManagement
{
    using Microsoft.Extensions.DependencyInjection;

    using Models;

    using Translators;

    using UseCases;

    public static class IoCConfig
    {
        public static void Configure(IServiceCollection services)
        {
            services.AddScoped<IFormationContext>(_ => new FormationContext());
            services.AddTransient<IReader<Person>, Reader<Person>>();
            services.AddTransient<IGetSimpleCards, GetSimpleCards>();
            services.AddTransient<IGetProfilCardByPersonId, GetProfilCardByPersonId>();
            services.AddTransient<ITranslator<Person, SimpleCard>, PersonToSimpleCardTranslator>();
            services.AddTransient<ITranslator<Person, ProfileCard>, PersonToProfileCardTranslator>();
        }
    }
}
