using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany.Vehicle
{
    interface IVehicle
    {
        string Type { get; }
        string Name { get; set; }
    }
}
