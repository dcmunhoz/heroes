using Heroes.Domain.Command.Heroes;
using Heroes.Domain.Interfaces.Heroes;
using Heroes.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes.Domain.Servicos.Heroes
{
    public  class HeroService : IHeroService
    {

        private IHeroRepositorio _repositorio;

        public HeroService(IHeroRepositorio repositorio)
        {
            _repositorio = repositorio;
        }


        public Hero Registrar(RegistrarHeroCommand command)
        {

            // Realizar a validação do comando aqui.
            // Continuar o fluxo se TRUE

            var hero = new Hero(command);
            return _repositorio.Registrar(hero);
        }
    }
}
