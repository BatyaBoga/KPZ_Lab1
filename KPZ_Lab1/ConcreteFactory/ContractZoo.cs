
using KPZ_Lab1.ConcretAnimal;
using KPZ_Lab1.Interfaces;

namespace KPZ_Lab1.ConcreteFactory
{
    class ContarctZoo : AbstractZoo
    {
        public override ICat GiveCat()
        {
            return new CatInCotractZoo();
        }

        public override ICrow GiveCrow()
        {
            return new CrowInContractZoo();
        }

        public override ILion GiveLion()
        {
            return new LionInContractZoo();
        }
    }
}
