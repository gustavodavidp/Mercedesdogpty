using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetrasBlog.Infraestructure.Entities
{
    public class Contabilidades
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
            public int Servicio_Id { get; set; }
            public string Tipo { get; set; }
            public int Perro_Id { get; set; }
            public float Monto { get; set; }
            public string Metodo { get; set; }
            public string Fecha { get; set; }
            public string Observacion { get; set; }

        }

    }
}
