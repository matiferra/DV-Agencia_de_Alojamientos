using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class AgenciaManager
    {
        public int id { get; set; }
        public Usuario id_usuario { get; set; }
        public Reserva id_reserva { get; set; }
        public Agencia id_agencia { get; set; }
    }
}
