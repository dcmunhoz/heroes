using Heroes.Domain.Model;

namespace Heroes.Domain.Interfaces.Heroes
{
    public interface IHeroRepositorio
    {
        public Hero Registrar(Hero hero);
    }
}
