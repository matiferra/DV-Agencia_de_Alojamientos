using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;




namespace Entities
{
    public class Reserva
    {
        public int id { get; set; }
        public int contador { get; set; } = 0;
        public DateTime FDesde { get; set; }
        public DateTime FHasta { get; set; }
        public Alojamiento id_alojamiento { get; set; }

        public Usuario id_usuario { get; set; }
        public float precio { get; set; }

    }
}

