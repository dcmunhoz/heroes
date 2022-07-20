using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Heroes.Domain.Dto.Requisicoes.Heroes.Requests;
using Heroes.Domain.Dto.Requisicoes.Heroes.Response;

namespace Heroes.Application.Interfaces.Hero
{
    public interface IHeroAppService
    {
        RegistrarHeroResponse Registrar(RegistrarHeroRequest request);
    }
}
