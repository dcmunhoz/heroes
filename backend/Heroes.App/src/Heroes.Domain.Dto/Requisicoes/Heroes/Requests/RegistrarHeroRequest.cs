using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes.Domain.Dto.Requisicoes.Heroes.Requests
{
    public class RegistrarHeroRequest : Requisicoes
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Power { get; set; }
        public int Defense { get; set; }
    }
}
