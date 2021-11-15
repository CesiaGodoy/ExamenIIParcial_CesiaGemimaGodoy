using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenIIParcial_CesiaGemimaGodoy.Modelos.Entidades
{
    public class Ticket: Cliente
    {
        public int IdTicket { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Precio { get; set; }
    }
}
