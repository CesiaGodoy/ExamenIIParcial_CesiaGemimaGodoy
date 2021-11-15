using ExamenIIParcial_CesiaGemimaGodoy.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenIIParcial_CesiaGemimaGodoy.Vistas
{
    public partial class EstadoTicketView : Form
    {
        public EstadoTicketView()
        {
            InitializeComponent();
            EstadoController controlador = new EstadoController(this);
        }
    }
}
