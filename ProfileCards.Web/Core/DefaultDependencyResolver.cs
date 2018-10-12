namespace ProfileCards.Web.Core
{
    using System;
    using System.Collections.Generic;
    using System.Web.Http.Dependencies;

    using Microsoft.Extensions.DependencyInjection;

    internal class DefaultDependencyResolver : IDependencyResolver
    {
        private IServiceProvider provider;

        public DefaultDependencyResolver(IServiceProvider provider)
        {
            this.provider = provider;
        }

        public IDependencyScope BeginScope()
        {
            return this;
        }
        
        public object GetService(Type serviceType)
        {
            return this.provider.GetService(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return this.provider.GetServices(serviceType);
        }

        public void Dispose()
        {
        }
    }
}