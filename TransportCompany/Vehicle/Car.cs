using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany.Vehicle
{
    class Car : IVehicle
    {
        private readonly string _type;

        public Car()
        {
            _type = "Автомобиль";
        }

        public string Type => _type;
        public string Name { get; set; }
    }
}
