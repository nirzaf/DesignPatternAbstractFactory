using DesignPatternAbstractFactory.Models;

namespace DesignPatternAbstractFactory.Factory
{
    class LargeGroupFactory : AbstractFactory
    {
        public override Vehicle CreateLandVehicle()
        {
            return new Bus();
        }

        public override Vehicle CreateSeaVehicle()
        {
            return new Cruise();
        }
    }
}
