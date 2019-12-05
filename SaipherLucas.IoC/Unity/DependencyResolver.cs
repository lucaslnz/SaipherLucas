using Microsoft.Practices.Unity;
using prmToolkit.NotificationPattern;
using SaipherLucas.Domain.Interface.Repositories;
using SaipherLucas.Domain.Interface.Repositories.Base;
using SaipherLucas.Domain.Interface.Services;
using SaipherLucas.Domain.Services;
using SaipherLucas.Infra.Persistence;
using SaipherLucas.Infra.Persistence.Repositories;
using SaipherLucas.Infra.Persistence.Repositories.Base;
using SaipherLucas.Infra.Transactions;
using System.Data.Entity;

namespace SaipherLucas.IoC.Unity
{
    public static class DependencyResolver
    {
        public static void Resolve(UnityContainer container)
        {

            container.RegisterType<DbContext, SaipherLucasContext>(new HierarchicalLifetimeManager());

            //UnitOfWork
            container.RegisterType<IUnitOfWork, UnitOfWork>(new HierarchicalLifetimeManager());
            container.RegisterType<INotifiable, Notifiable>(new HierarchicalLifetimeManager());

            //Serviço de Domain
            //container.RegisterType(typeof(IServiceBase<,>), typeof(ServiceBase<,>));

            container.RegisterType<IServiceAeronave, ServiceAeronave>(new HierarchicalLifetimeManager());
            container.RegisterType<IServiceAeroporto, ServiceAeroporto>(new HierarchicalLifetimeManager());
            container.RegisterType<IServiceVoo, ServiceVoo>(new HierarchicalLifetimeManager());
            container.RegisterType<IServicePlanoVoo, ServicePlanoVoo>(new HierarchicalLifetimeManager());

            //Repository
            container.RegisterType(typeof(IBaseRepository<,>), typeof(BaseRepository<,>));

            container.RegisterType<IRepositoryAeronave, RepositoryAeronave>(new HierarchicalLifetimeManager());
            container.RegisterType<IRepositoryAeroporto, RepositoryAeroporto>(new HierarchicalLifetimeManager());
            container.RegisterType<IRepositoryVoo, RepositoryVoo>(new HierarchicalLifetimeManager());
            container.RegisterType<IRepositoryPlanoVoo, RepositoryPlanoVoo>(new HierarchicalLifetimeManager());
        }
    }
}
