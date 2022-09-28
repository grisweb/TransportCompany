using TransportCompany.Vehicle;

namespace TransportCompany.Factory
{
    abstract class VehicleFactory
    {
        public abstract IVehicle CreateVehicle();
    }
}
