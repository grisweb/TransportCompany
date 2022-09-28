using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany.Vehicle
{
    class Ship : IVehicle
    {
        private readonly string _type;

        public Ship()
        {
            _type = "Корабль";
        }

        public string Type => _type;
        public string Name { get; set; }
    }
}
