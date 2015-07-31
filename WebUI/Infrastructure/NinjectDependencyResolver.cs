using Ninject;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace EstimatorApp.WebUI.Infrastructure
{
    using Domain.Abstract;
    using Repository.Concrete;

    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;

        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }

        private void AddBindings()
        {
            kernel.Bind<IUsersRepository>().To<UsersRepository>().InSingletonScope();
            kernel.Bind<IRolesRepository>().To<RolesRepository>().InSingletonScope();
        }
    }
}