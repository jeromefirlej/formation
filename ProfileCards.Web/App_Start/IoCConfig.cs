using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProfileCards.Web
{
    using Microsoft.Extensions.DependencyInjection;

    using ProfilesManagement.Translators;
    using ProfilesManagement.UseCases;

    internal static class IoCConfig
    {
        public static IServiceProvider Configure()
        {
            var services = new ServiceCollection();
            ProfilesManagement.IoCConfig.Configure(services);
            return services.BuildServiceProvider();
        }
    }
}