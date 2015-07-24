using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Ninject;
using EstimatorApp.Repository.Concrete;
using EstimatorApp.Domain.Abstract;

namespace EstimatorApp.WebUI.Infrastructure
{
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