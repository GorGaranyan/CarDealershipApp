using CarDealershipApp.Domain;
using CarDealershipApp.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealershipApp.Commands
{
    public class ListClientCommand:ClientCommand
    {
        public ListClientCommand(ClientRepository clientRepository) : base(clientRepository) { }
        public override string CommandText()
        {
            return "list clients";
        }
        public override CommandResult Execute()
        {
            
            Console.WriteLine("______________________________");
            foreach (Client client in _clientRepository.List())
            {
                Console.WriteLine(client.Name+" " +client.Surename+" | "+client.PassportID);
                if(client.Cars!=null)
                {
                    Console.Write("Cars count: "+client.Cars.Count);
                    Console.WriteLine();
                    foreach(Car car in client.Cars)
                    {
                        Console.Write(car.Number + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("______________________________");
            }
            return new CommandResult(true, $"Listed {_clientRepository.Count()} clients");

         
        }
    }
}
