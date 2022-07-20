using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes.Domain.Command.Heroes
{
    public class RegistrarHeroCommand
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Power { get; set; }
        public int Defense { get; set; }
    }
}
