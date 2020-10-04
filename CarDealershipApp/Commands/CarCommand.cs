using CarDealershipApp.Repository;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace CarDealershipApp.Commands
{
    public abstract class CarCommand : Command
    {
        protected CarRepository _carRepository;
        protected ClientRepository _clientRepository;
        public CarCommand(CarRepository carRepository)
        {
            _carRepository = carRepository;
        }

    }
        

}
       
        
    
