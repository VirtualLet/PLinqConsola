using Linq_Repaso.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Repaso._31_JoinOperations
{
 public   class Join
    {
        public void JoinEjem()
        {
            Console.WriteLine("\n------" + System.Reflection.MethodBase.GetCurrentMethod().Name + "------\n");//Obtiene el nombre del metodo
            Console.WriteLine("Join:Used to get data from 2 data-sources");
        }

        public void GroupJoinEjem()
        {
            Console.WriteLine("\n------" + System.Reflection.MethodBase.GetCurrentMethod().Name + "------\n");//Obtiene el nombre del metodo
            Console.WriteLine("GroupJoin:Used to get data from 2 data-sources by grouping all the elements" +
                "Group join is used to group the result based on common key\n");

            var trabajador = new Trabajador().DataTrabajador();
            var direccion = new Address().DataAddress();

            var selectMethod = direccion.GroupJoin(trabajador, direc => direc.Id,
                                                              traba => traba.AddressId,
                                                              (direc, traba) => new { direc, traba }).ToList();
                                        
                                                           

            foreach (var item in selectMethod)
            {
                Console.WriteLine("idDireccion:{0} Linea:{1} ==>",item.direc.Id,item.direc.AddressLine );
                foreach(var e in item.traba)
                {
                    Console.WriteLine("Id:{0} Name:{1},IdDireccion:{2}",e.Id,e.Name,e.AddressId);
                }
            }

            Console.WriteLine("\n--Forma Query---\n");
            var selectQuery = from direc in direccion
                              join traba in trabajador on direc.Id equals traba.AddressId into trabaGroups
                              select new { direc, trabaGroups };

            foreach (var item in selectQuery)
            {
                Console.WriteLine("idDireccion:{0} Linea:{1} ==>", item.direc.Id, item.direc.AddressLine);
                foreach (var e in item.trabaGroups)
                {
                    Console.WriteLine("Id:{0} Name:{1},IdDireccion:{2}", e.Id, e.Name, e.AddressId);
                }
            }

        }

        public void InnerJoinCon2Tablas()
        {
            Console.WriteLine("\n------" + System.Reflection.MethodBase.GetCurrentMethod().Name + "------\n");//Obtiene el nombre del metodo
            Console.WriteLine("Inner join:Elements which has a common properties in both the data-sources");

            var dataTrabajador = new Trabajador().DataTrabajador();
            var dataAddress = new Address().DataAddress();

            var selectQuery = (from trabajador in dataTrabajador
                               join address in dataAddress
                                             on trabajador.AddressId equals address.Id
                               select new
                               {
                                   NombreTrabajador = trabajador.Name,
                                   Linea = address.AddressLine
                               }).ToList();


            var selectMethod = dataTrabajador.Join(dataAddress,
                                                    trabajador => trabajador.AddressId,
                                                    address => address.Id,
                                                    (trabajador, address) => new { trabajador, address })
                                              .Select(item=>new
                                                    {
                                                         NombreTrabajador= item.trabajador.Name,
                                                         Linea=item.address.AddressLine
                                                    }).ToList();

            foreach(var item in selectQuery)
            {
                Console.WriteLine(item);
            }
        }

        public void InnerJoinCon3Tablas()
        {
            Console.WriteLine("\n------" + System.Reflection.MethodBase.GetCurrentMethod().Name + "------\n");//Obtiene el nombre del metodo
            var dataTrabajador = new Trabajador().DataTrabajador();
            var dataAddress = new Address().DataAddress();
            var dataMark = new Marks().DataMarks();

            var selectQuery = (from trabajador in dataTrabajador
                               join address in dataAddress
                                            on trabajador.AddressId equals address.Id
                               join mark    in dataMark
                                            on trabajador.Id equals mark.TrabajadorId
                               select new
                               {
                                   NombreTrabajador = trabajador.Name,
                                   Linea = address.AddressLine,
                                   Marca=mark.TMarks
                               }).ToList();


            var selectMethod = dataTrabajador.Join(dataAddress,
                                                    trabajador => trabajador.AddressId,
                                                    address => address.Id,
                                                  (trabajador, address) => new { trabajador, address })
                                              .Join(dataMark,
                                                    trabajadorMark => trabajadorMark.trabajador.Id,
                                                    mark => mark.TrabajadorId,
                                                    (trabajadorMark, mark) => new { trabajadorMark, mark })
                                              .Select(item => new
                                              {
                                                  NombreTrabajador = item.trabajadorMark.trabajador.Name,
                                                  Linea = item.trabajadorMark.address.AddressLine,
                                                  Marca = item.mark.TMarks
                                              }).ToList();


            foreach (var item in selectQuery)
            {
                Console.WriteLine(item);
            }
        }

        public void LeftJoin()
        {
            Console.WriteLine("\n------" + System.Reflection.MethodBase.GetCurrentMethod().Name + "------\n");//Obtiene el nombre del metodo

            var dataTrabajador = new Trabajador().DataTrabajador();
            var dataDireccion = new Address().DataAddress();

            var selectQuery = (from traba in dataTrabajador
                               join direc in dataDireccion on traba.AddressId equals direc.Id into traDirec
                               from trabaDirec in traDirec.DefaultIfEmpty()
                               select new
                               {
                                   id = traba.Id,
                                   nombre = traba.Name,
                                   direccion = trabaDirec != null ? trabaDirec.AddressLine : "NA"
                               }).ToList();
                               //select new
                               //{  traba, trabaDirec
                               //}).ToList();
            

            foreach (var item in selectQuery)
            {
                 Console.WriteLine(item);
               // Console.WriteLine("Name:{0} IdDirec:{1}, AddresLine:{2}",item.traba.Name,item.traba.AddressId,item.trabaDirec != null ? item.trabaDirec.AddressLine : "NA");
            }

            Console.WriteLine("\n---------\n");
            var selectMethod = dataTrabajador.GroupJoin(dataDireccion, traba => traba.AddressId, direc => direc.Id,
                                                       (traba, direc) => new { 
                                                                               traba, 
                                                                               direc 
                                                       })
                                            .SelectMany(x => x.direc.DefaultIfEmpty(),
                                                       (trabajador, direccion) => new {
                                                                                     trabajador.traba,
                                                                                     direccion
                                                       }).ToList();


            foreach (var item in selectMethod)
            {
                Console.WriteLine(item.direccion!=null?item.direccion.AddressLine:"NA");
            }
        }

    }
}
