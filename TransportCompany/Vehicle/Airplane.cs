using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany.Vehicle
{
    class Airplane : IVehicle
    {
        private readonly string _type;

        public Airplane()
        {
            _type = "Самолет";
        }

        public string Type => _type;
        public string Name { get; set; }
    }
}
