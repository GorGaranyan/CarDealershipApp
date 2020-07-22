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
                Console.WriteLine("______________________________");
            }
            return new CommandResult(true, $"Listed {_clientRepository.Count()} clients");

         
        }
    }
}
