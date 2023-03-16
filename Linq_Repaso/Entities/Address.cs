using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Repaso.Entities
{
 public   class Address
    {
        public int Id { get; set; }
        public string AddressLine { get; set; }


        public List<Address> DataAddress()
        {
            var data = new List<Address> {
                new Address{ Id=1, AddressLine="Line 1"},
                new Address{ Id=2, AddressLine="Line 2"},
                new Address{ Id=3, AddressLine="Line 3"},
                new Address{ Id=4, AddressLine="Line 4"},
                new Address{ Id=5, AddressLine="Line 5"},
            };
            return data;
        }
    }
}
