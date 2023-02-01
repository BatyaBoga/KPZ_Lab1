using KPZ_Lab1.Interfaces;

namespace KPZ_Lab1
{
    abstract class AbstractZoo
    {
        public abstract ICat GiveCat();

        public abstract ICrow GiveCrow();

        public abstract ILion GiveLion();
    }
}
