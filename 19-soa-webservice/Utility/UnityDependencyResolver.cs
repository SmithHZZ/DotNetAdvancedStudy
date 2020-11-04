using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Dependencies;
using Unity;

namespace _19_soa_webservice.Utility
{
    public class UnityDependencyResolver : IDependencyResolver
    {
        private IUnityContainer _container = null;

        public UnityDependencyResolver(IUnityContainer container)
        {
            _container = container;
        }

        public IDependencyScope BeginScope()
        {
            return new UnityDependencyResolver(_container.CreateChildContainer());
        }

        public void Dispose()
        {
            _container.Dispose();
        }

        public object GetService(Type serviceType)
        {
            try
            {
                return _container.Resolve(serviceType);
            }
            catch(Exception exc)
            {
                Console.WriteLine(exc.Message);
                return null;
            }

        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _container.ResolveAll(serviceType);
        }
    }
}