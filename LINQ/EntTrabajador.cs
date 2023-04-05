using System.Collections.Generic;

namespace LINQ
{
    public  class EntTrabajador
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AddressId { get; set; }


        public List<EntTrabajador> DataTrabajador()
        {
            var data = new List<EntTrabajador> { 
                new EntTrabajador { Id=1, Name="Armando1", AddressId=1},
                new EntTrabajador { Id=2, Name="Antonia2", AddressId=0},
                new EntTrabajador { Id=3, Name="Alejandra3", AddressId=2},
                new EntTrabajador { Id=4, Name="America4", AddressId=0},
                new EntTrabajador { Id=5, Name="Alan5", AddressId=3},
            };
            return data;
        }
    }
}
