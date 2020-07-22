using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealershipApp.Domain
{
    public class Client
    {
        public string Name;
        public string Surename;
        public string PassportID;

        public Client(string name, string surename, string passportid)
        {
            Name = name;
            Surename = surename;
            PassportID = passportid;
        }
    }
}
