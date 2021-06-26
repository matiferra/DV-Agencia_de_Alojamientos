using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Hotel
    {
        public int id { get; set; }
        public double precio_por_persona { get; set; }
        public Alojamiento id_alojamiento { get; set; }


    }
}
