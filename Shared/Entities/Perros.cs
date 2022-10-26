using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetrasBlog.Infraestructure.Entities
{
    public class Perros
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
            public int DuenoId { get; set; }
            public string Nombre { get; set; }
            public string Raza { get; set; }
            public int Edad { get; set; }
            public string Observacion { get; set; }
            public int CreadoPor { get; set; }
            public int ModifPor { get; set; }
            public string FechaCreacion { get; set; }
            public string FechaModif { get; set; }
        }

    }
}
