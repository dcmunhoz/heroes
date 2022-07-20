using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Heroes.Application.Interfaces.Hero;
using Heroes.Application.Servico.Hero;
using Heroes.Domain.Interfaces.Heroes;
using Heroes.Domain.Servicos.Heroes;
using Heroes.Infra.Persistencia.Repositorios;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class DependencyInjection
    {
        public static void AddDependencias(this IServiceCollection services)
        {
            // AppServices
            services.AddTransient<IHeroAppService, HeroAppService>();

            // Domain Services
            services.AddTransient<IHeroService, HeroService>();

            // Repositórios
            services.AddTransient<IHeroRepositorio, HeroRepositorio>();
        }
    }
}
