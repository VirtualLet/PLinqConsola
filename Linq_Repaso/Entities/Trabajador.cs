using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Repaso.Entities
{
  public  class Trabajador
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AddressId { get; set; }


        public List<Trabajador> DataTrabajador()
        {
            var data = new List<Trabajador> { 
                new Trabajador { Id=1, Name="Armando1", AddressId=1},
                new Trabajador { Id=2, Name="Antonia2", AddressId=0},
                new Trabajador { Id=3, Name="Alejandra3", AddressId=2},
                new Trabajador { Id=4, Name="America4", AddressId=0},
                new Trabajador { Id=5, Name="Alan5", AddressId=3},
            };
            return data;
        }
    }
}
