using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingAndFlatManagement
{
    internal class TenantClass: FS
    {
        private int rent;
        public int Rent
        {
            set{ rent = value; }
            get{ return rent; }
        }

        public  TenantClass():base()
        { 
        
        }
        public TenantClass(string name, string phone, string email, string address, string gender, string block,int rent) :base(name,phone,email,address,gender,block)
        {
            this.rent = rent;
        }
    }
}
