using DesignPatternAbstractFactory.Models;

namespace DesignPatternAbstractFactory.Factory
{
   abstract class AbstractFactory
    {
        public abstract Vehicle CreateLandVehicle();
        public abstract Vehicle CreateSeaVehicle();
    }
}
