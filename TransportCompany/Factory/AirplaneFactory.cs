using TransportCompany.Vehicle;

namespace TransportCompany.Factory
{
    class AirplaneFactory : VehicleFactory
    {
        public override IVehicle CreateVehicle()
        {
            return new Airplane();
        }
    }
}
