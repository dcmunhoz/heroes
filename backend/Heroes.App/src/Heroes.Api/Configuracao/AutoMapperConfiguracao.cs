using System;
using Heroes.Application.Mapper.Hero;
using AutoMapper.Configuration;
using AutoMapper;
using System.Reflection;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class AutoMapperConfiguracao 
    {
        public static void AddAutoMapperConfiguacao(this IServiceCollection service)
        {
            service.AddAutoMapper(typeof(HeroProfile));

        }
    }
}
