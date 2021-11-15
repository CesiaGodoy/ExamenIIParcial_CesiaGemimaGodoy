using ExamenIIParcial_CesiaGemimaGodoy.Modelos.DAO;
using ExamenIIParcial_CesiaGemimaGodoy.Modelos.Entidades;
using ExamenIIParcial_CesiaGemimaGodoy.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenIIParcial_CesiaGemimaGodoy.Controladores
{
    public class DetalleController
    {
        DetalleTicketView vista;
        string operacion = string.Empty;
        DetalleDAO clientDAO = new DetalleDAO();
        DetalleTicket client = new DetalleTicket();

        public DetalleController(DetalleTicket view)
        {
           

        }
    }
    
}
