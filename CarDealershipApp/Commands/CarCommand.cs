using CarDealershipApp.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealershipApp.Commands
{
    public abstract class CarCommand : Command
    {
        protected CarRepository _carRepository;
        protected ClientRepository _clientRepository;
        public CarCommand(CarRepository carRepository, ClientRepository clientRepository)
        {
            _carRepository = carRepository;
            _clientRepository = clientRepository;
        }
       
        
    }
}
