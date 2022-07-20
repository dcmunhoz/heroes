using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Heroes.Domain.Dto.Requisicoes.Heroes.Requests;
using Heroes.Domain.Dto.Requisicoes.Heroes.Response;
using Heroes.Domain.Command.Heroes;
using Heroes.Domain.Model;

namespace Heroes.Application.Mapper.Hero
{
    public class HeroProfile : Profile
    {
        public HeroProfile()
        {
            CreateMap<RegistrarHeroRequest, RegistrarHeroCommand>();
            CreateMap<Domain.Model.Hero, RegistrarHeroResponse>();
        }
    }
}
