using Heroes.Domain.Interfaces.Heroes;
using Heroes.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes.Infra.Persistencia.Repositorios
{
    public class HeroRepositorio : IHeroRepositorio
    {

        private AppDbContext _context;

        public HeroRepositorio(AppDbContext context)
        {
            _context = context;
        }

        public Hero Registrar(Hero hero)
        {
            _context.Heroes.Add(hero);
            _context.SaveChanges();

            return hero;
        }
    }
}
