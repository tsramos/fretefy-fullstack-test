using Fretefy.Test.Domain.Interfaces;
using Fretefy.Test.Domain.Interfaces.Repositories;
using Fretefy.Test.Domain.Interfaces.Services;
using Fretefy.Test.Domain.Services;
using Fretefy.Test.Infra.EntityFramework.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Fretefy.Test.IOC
{
    public static class DependencyInjectionExetension
    {
        public static void AddDomainServices(this IServiceCollection services)
        {
            services.AddScoped<ICidadeService, CidadeService>();
            services.AddScoped<IRegiaoService, RegiaoService>();
        }

        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<ICidadeRepository, CidadeRepository>();
            services.AddScoped<IRegiaoRepository, RegiaoRepository>();
            services.AddScoped<IRegiaoCidadeRepository, RegiaoCidadeRepository>();
        }
    }
}
