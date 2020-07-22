using CarDealershipApp.Domain;
using CarDealershipApp.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealershipApp.Commands
{
    public class AddClientCommand : ClientCommand
    {
        public AddClientCommand(ClientRepository clientRepository) : base(clientRepository) { }

        public override string CommandText()
        {
            return "add client";
        }
        public override CommandResult Execute()
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Surename: ");
            string surename = Console.ReadLine();
            Console.Write("Passport ID: ");
            string passportid = Console.ReadLine();
            Client client = new Client(name, surename, passportid);
            bool success = _clientRepository.Add(client);
            string message = "Client added succesfully";
            if(!success)
            {
                message = $"Client with passport's ID {passportid} already exists";
            }

            return new CommandResult(success, message);
        }
    }  
}
