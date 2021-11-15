using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenIIParcial_CesiaGemimaGodoy.Modelos.Entidades
{
    public class DetalleTicket
    {
        public int Id { get; set; }
        public int Cantidad { get; set; }
        public int IdTipo { get; set; }
        public int IdEstado { get; set; }
        public int IdTicket { get; set; }
        
    }
}
