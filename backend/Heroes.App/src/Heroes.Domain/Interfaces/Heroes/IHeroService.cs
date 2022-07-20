using Heroes.Domain.Command.Heroes;
using Heroes.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes.Domain.Interfaces.Heroes
{
    public interface IHeroService
    {
        public Hero Registrar(RegistrarHeroCommand command);
    }
}
