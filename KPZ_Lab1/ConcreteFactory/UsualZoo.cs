
using KPZ_Lab1.ConcretAnimal;
using KPZ_Lab1.Interfaces;

namespace KPZ_Lab1.ConcreteFactory
{
    class UsualZoo : AbstractZoo
    {
        public override ICat GiveCat()
        {
            return new CatInUsualZoo();
        }

        public override ICrow GiveCrow()
        {
            return new CrowInUsualZoo();
        }

        public override ILion GiveLion()
        {
            return new LionInUsualZoo();
        }
    }
}
