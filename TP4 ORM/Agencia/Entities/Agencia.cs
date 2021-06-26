using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Agencia
    {
        public int id { get; set; }
        public static int CantAloj { get; set; }
        public Alojamiento id_alojamiento { get; set; }
        public int cantAlojamientos { get; set; }

    }
}
