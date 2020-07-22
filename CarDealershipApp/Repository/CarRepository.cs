using CarDealershipApp.Commands;
using CarDealershipApp.Domain;
using System;
using System.Collections.Generic;
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

        public bool Sell(string number)
        {
            foreach(Car car in _cars)
            {
                if(number==car.Number)
                {
                    _cars.Remove(car);
                    return true;
                }
            }

            return false;
        }
    }
}
