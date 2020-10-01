using CarDealershipApp.Domain;
using CarDealershipApp.Repository;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;


namespace CarDealershipApp.Commands
{
    public class SellCarCommand : CarCommand 
    {
        public SellCarCommand(CarRepository carRepository, ClientRepository clientRepository) : base(carRepository,clientRepository){ }

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
            Car car = _carRepository.GetCarByNumber(number);
            Client client = _clientRepository.GetClientByPassport(passport);
            string message = "";
            bool success = false;
            if (car != null && client != null)
            {
                success = _carRepository.Sell(car, client);
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
