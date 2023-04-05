using System.Collections.Generic;

namespace LINQ
{
    public   class EntAddress
    {
        public int Id { get; set; }
        public string AddressLine { get; set; }


        public List<EntAddress> DataAddress()
        {
            var data = new List<EntAddress> {
                new EntAddress{ Id=1, AddressLine="Line 1"},
                new EntAddress{ Id=2, AddressLine="Line 2"},
                new EntAddress{ Id=3, AddressLine="Line 3"},
                new EntAddress{ Id=4, AddressLine="Line 4"},
                new EntAddress{ Id=5, AddressLine="Line 5"},
            };
            return data;
        }
    }
}
