using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetrasBlog.Infraestructure.Entities
{
    public class Duenos
    {
        public class response
        {
            public int Code { get; set; }
            public string Message { get; set; }
            public List<Data> Detail { get; set; }
        }
        public class Data
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public string Cedula { get; set; }
            public string Pasaporte { get; set; }
            public string Telefono { get; set; }
            public string Celular { get; set; }
            public string Direccion { get; set; }
            public int CreadoPor { get; set; }
            public int ModifPor { get; set; }
            public string FechaCreacion { get; set; }
            public string FechaModif { get; set; }
        }

    }
}
