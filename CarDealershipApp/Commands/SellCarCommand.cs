using CarDealershipApp.Domain;
using CarDealershipApp.Repository;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Text;

namespace CarDealershipApp.Commands
{
    public class SellCarCommand : CarCommand
    {
        public SellCarCommand(CarRepository carRepository) : base(carRepository) { }

        public override string CommandText()
        {
            return "sell car";
        }

        public override CommandResult Execute()
        {
            Console.Write("Car number: ");
            string number = Console.ReadLine();
            Console.WriteLine("Client passport: ");
            string passport = Console.ReadLine();
            object car = _carRepository.GetCarByNumber(number);
            ClientRepository _clientRepository = new ClientRepository();
            object client = _clientRepository.GetClientByPassport(passport);
            string message = "";
            bool success = false;
            if (car is Car && client is Client)
            {
                success = _carRepository.Sell((Car)car, (Client)client);
                message = "Car sold succesfully";
            }
            else
            {
                    message= "Wrong car number or passport ID";
            }
            return new CommandResult(success, message);
        }
    }
}
