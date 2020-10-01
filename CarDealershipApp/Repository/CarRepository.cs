using CarDealershipApp.Commands;
using CarDealershipApp.Domain;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace CarDealershipApp.Repository
{
    public class CarRepository
    {
        private LinkedList<Car> _cars;

        public CarRepository()
        {
            _cars = new LinkedList<Car>();
        }

        public int Count()
        {
            return _cars.Count;
        }

        public LinkedList<Car> List()
        {
            return _cars;
        }

        public bool Add(Car car)
        {
            string number = car.Number;

            foreach (Car _car in _cars)
            {
                if (number == _car.Number)
                {
                    return false;
                }
            }

            _cars.AddLast(car);
            return true;
        }

        public bool Sell(Car car,Client client)
        {
            ClientRepository clientRepository = new ClientRepository();
            client.Cars = new List<Car>();
            client.Cars.Add(car);
            
            car.IsSold = true;
            _cars.Remove(car);


            return true;
        }
        public Car GetCarByNumber(string number)
        {
            foreach(Car car in _cars)
            {
                if(number==car.Number)
                {
                    return car;
                }
            }
            return null;
        }
    }
}
