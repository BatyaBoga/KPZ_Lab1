
using KPZ_Lab1.ConcretAnimal;
using KPZ_Lab1.Interfaces;

namespace KPZ_Lab1.ConcreteFactory
{
    class ContactZoo : AbstractZoo
    {
        public override ICat GiveCat()
        {
            return new CatInContactZoo();
        }

        public override ICrow GiveCrow()
        {
            return new CrowInContactZoo();
        }

        public override ILion GiveLion()
        {
            return new LionInContactZoo();
        }
    }
}
