using TransportCompany.Vehicle;

namespace TransportCompany.Factory
{
    class ShipFactory : VehicleFactory
    {
        public override IVehicle CreateVehicle()
        {          
            return new Ship();
        }
    }
}
