using System;
using System.Collections.Generic;
using TransportCompany.Factory;
using TransportCompany.Vehicle;

namespace TransportCompany
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберете транспортные средства для вашего маршрута!");
            Console.WriteLine("1. Автомобиль");
            Console.WriteLine("2. Корабль");
            Console.WriteLine("3. Самолет");

            List<IVehicle> vehicles = new List<IVehicle>();

            while (true)
            {
                Console.Write("Введите номер типа транспортного средства: ");
                string number = Console.ReadLine();

                VehicleFactory vehicleFactory = GetFactory(number);

                if (vehicleFactory == null)
                {
                    Console.WriteLine("Типа транспортного средства с таким номером не существует!");
                    continue;
                }
                else
                {
                    IVehicle vehicle = vehicleFactory.CreateVehicle();
                    Console.Write("Введите название транспортного средства: ");
                    string name = Console.ReadLine();
                    vehicle.Name = name;
                    vehicles.Add(vehicle);

                    Console.Write("Продолжить (да/нет): ");
                    string status = Console.ReadLine();

                    if (status == "да")
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            if (vehicles.Count != 0)
            {
                Console.WriteLine("Ваш заказ: ");

                for (int i = 0; i < vehicles.Count; i++)
                {
                    Console.WriteLine(i + 1 + ". " + vehicles[i].Type +  " \"" + vehicles[i].Name + "\"");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Программа завершена!");
            Console.ReadLine();
        }

        static VehicleFactory GetFactory(string number)
        {
            switch (number)
            {
                case "1": return new CarFactory();
                case "2": return new ShipFactory();
                case "3": return new AirplaneFactory();
                default: return null;
            }
        }
    }
}
