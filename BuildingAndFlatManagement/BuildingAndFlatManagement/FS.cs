using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingAndFlatManagement
{
    internal class FS
    {
        public string name;
        public string phone;
        public string email;
        public string address;
        public string gender;
        public string block;

        public FS() { }
        public FS(string name,string phone,string email,string address,string gender,string block)
        { 
            this.name = name;
            this.phone = phone;
            this.email = email;
            this.address = address;   
            this.gender = gender;
            this.block = block;
        }

    }
}
