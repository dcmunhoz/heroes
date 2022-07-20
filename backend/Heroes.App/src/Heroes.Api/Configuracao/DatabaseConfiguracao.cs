using Heroes.Infra.Persistencia;
using Microsoft.Extensions.Configuration;
using Oracle.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class DatabaseConfiguracao
    {

        public static void AddDatabaseConfiguracao(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseOracle(config.GetConnectionString("Oracle")));
        }

    }
}
