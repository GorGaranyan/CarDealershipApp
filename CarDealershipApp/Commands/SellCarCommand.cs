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
            string message = "Car sold succesfully";
            Console.Write("Car number: ");
            string number = Console.ReadLine();
            bool success = _carRepository.Sell(number);
            if (!success)
            {
                message = $"Car with number {number} does not exist";
            }
            
            
            return new CommandResult(success, message);

        }
    }
}
