using Autofac;
using RestAPIDDDModel.Application;
using RestAPIDDDModel.Application.Interfaces;
using RestAPIDDDModel.Application.Interfaces.Mappers;
using RestAPIDDDModel.Domain.Core.Intefaces.Repositories;
using RestAPIDDDModel.Domain.Core.Intefaces.Services;
using RestAPIDDDModel.Domain.Services;
using RestAPIDDDModel.Infrastructure.CrossCutting.Mapper;
using RestAPIDDDModel.Infrastructure.Data.Repositories;

namespace RestAPIDDDModel.Infrastructure.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region IOC

            #region Client

            builder.RegisterType<ApplicationServiceClient>().As<IApplicationServiceClient>();
            builder.RegisterType<ServiceClient>().As<IServiceClient>();
            builder.RegisterType<RepositoryCliente>().As<IRepositoryClient>();
            builder.RegisterType<MapperClient>().As<IMapperClient>();

            #endregion Client

            #region Product

            builder.RegisterType<ApplicationServiceProduct>().As<IApplicationServiceProduct>();
            builder.RegisterType<ServiceProduct>().As<IServiceProduct>();
            builder.RegisterType<RepositoryProduct>().As<IRepositoryProduct>();
            builder.RegisterType<MapperProduct>().As<IMapperProduct>();

            #endregion Product

            #endregion IOC
        }
    }
}