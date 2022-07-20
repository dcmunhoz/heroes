using Heroes.Application.Interfaces.Hero;
using Heroes.Domain.Dto.Requisicoes.Heroes.Requests;
using Heroes.Domain.Dto.Requisicoes.Heroes.Response;
using Heroes.Domain.Command.Heroes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Heroes.Domain.Interfaces.Heroes;

namespace Heroes.Application.Servico.Hero
{
    public class HeroAppService : IHeroAppService
    {
        private IMapper _mapper;
        private IHeroService _service;

        public HeroAppService(IMapper mapper, IHeroService service)
        {
            _mapper = mapper;
            _service = service;
        }

        public RegistrarHeroResponse Registrar(RegistrarHeroRequest request)
        {

            var comando = _mapper.Map<RegistrarHeroCommand>(request);

            return _mapper.Map<RegistrarHeroResponse>(_service.Registrar(comando));
        }
    }
}
