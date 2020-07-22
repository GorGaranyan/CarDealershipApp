using CarDealershipApp.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using CarDealershipApp.Domain;
using System.Security.Cryptography.X509Certificates;
using System.Net.Http;

namespace CarDealershipApp.Commands
{
    public class AddCarCommand : CarCommand
    {
        public AddCarCommand(CarRepository carRepository) : base(carRepository) { }

        public override string CommandText()
        {
            return "add car";
        }
        
        public override CommandResult Execute()
        {
            Console.Write("Car number: ");
            string number = Console.ReadLine();
            Console.Write("Car model: ");
            string model = Console.ReadLine();
            Console.Write("Year making: ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Car color: ");
            string color = Console.ReadLine();
            Console.Write("Car price: ");
            long price = Convert.ToInt32(Console.ReadLine());
            Car car = new Car(number, model, year, color, price);
            bool success = _carRepository.Add(car);
            string message = "Car added succesfully";
            if (!success)
            {
                message = $"Car with number {number} already exist";
            }
            return new CommandResult(success, message);
        }
    }
}
