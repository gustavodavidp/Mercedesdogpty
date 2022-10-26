using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetrasBlog.Infraestructure.Entities
{
    public class Entrenamientos
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
            public int IdPerro { get; set; }
            public string FechaInicial { get; set; }
            public string FechaFinal { get; set; }
            public float Costo { get; set; }
            public string Modalidad { get; set; }
            public string Horario { get; set; }
            public int CreadoPor { get; set; }
            public string FechaCreacion { get; set; }
            public int ModifPor { get; set; }
            public string FechaModif { get; set; }
        }

    }
}
