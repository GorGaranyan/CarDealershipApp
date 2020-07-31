using CarDealershipApp.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealershipApp.Repository
{
    public class ClientRepository
    {
        private LinkedList<Client> _clients;

        public ClientRepository()
        {
            _clients = new LinkedList<Client>();
        }

        public int Count()
        {
            return _clients.Count;
        }

        public LinkedList<Client> List()
        {
            return _clients;
        }

        public bool Add(Client client)
        {
            string id = client.PassportID;
            foreach(Client item in _clients)
            {
                if(id==item.PassportID)
                {
                    return false;
                }
            }
            _clients.AddLast(client);
            return true;
        }
        public object GetClientByPassport(string passport)
        {
            foreach(Client item in _clients)
            {
                if(passport==item.PassportID)
                {
                    return item;
                }
            }
            return false;
        }
    }
}
