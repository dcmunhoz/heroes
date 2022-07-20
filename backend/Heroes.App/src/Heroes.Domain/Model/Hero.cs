using Heroes.Domain.Command.Heroes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes.Domain.Model
{
    public class Hero
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Power { get; set; }
        public int Defense { get; set; }

        public Hero() { }

        public Hero(RegistrarHeroCommand command)
        {
            //this.Id = 10;
            this.Name = command.Name;
            this.Description = command.Description;
            this.Power = command.Power;
            this.Defense = command.Defense;
        }
    }
}
