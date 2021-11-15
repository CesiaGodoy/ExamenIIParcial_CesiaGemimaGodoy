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


        public string _EmailUsuario;

        public DetalleController(DetalleTicketView view, string usuario)
        {
            vista = view;
            _EmailUsuario = usuario;
            vista.Load += new EventHandler(Load);

        }

        private void Load(object sender, EventArgs e)
        {
            vista.UsuarioTextBox.Text = _EmailUsuario;
        }
    }
    
}
