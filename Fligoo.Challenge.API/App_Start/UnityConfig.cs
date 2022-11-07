using AutoMapper;
using Fligoo.Challenge.Data;
using Fligoo.Challenge.Data.Repository;
using Fligoo.Challenge.Services;
using Fligoo.Challenge.Services.Extensions;
using Fligoo.Challenge.Services.ExternalProviders;
using System.Net.Http;
using System.Web.Configuration;
using System.Web.Http;
using Unity;
using Unity.Lifetime;
using Unity.WebApi;

namespace Fligoo.Challenge.API
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            UnityContainer container = new UnityContainer();

            HttpClient httpClient = new HttpClient() { };
            httpClient.ConfigureHttpClient(WebConfigurationManager.AppSettings["FDExternalProviderUrl"],
                                           WebConfigurationManager.AppSettings["FDExternalProviderTokenHeader"],
                                           WebConfigurationManager.AppSettings["FDExternalProviderToken"]);

            MapperConfiguration config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new AutoMapperProfile());
            });

            container.RegisterInstance(config.CreateMapper());

            container.RegisterFactory<HttpClient>(x => httpClient);
            container.RegisterFactory<ApplicationDbContext>(x => ApplicationDbContext.Create());
            container.RegisterType<ICompetitionRepository, CompetitionRepository>();
            container.RegisterType<ICompetitionExternalProviderService, CompetitionExternalProviderService>(new HierarchicalLifetimeManager());
            container.RegisterType<ICompetitionService, CompetitionService>(new HierarchicalLifetimeManager());

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}