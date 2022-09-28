using TransportCompany.Vehicle;

namespace TransportCompany.Factory
{
    class CarFactory : VehicleFactory
    {
        public override IVehicle CreateVehicle()
        {
            return new Car();
        }
    }
}
