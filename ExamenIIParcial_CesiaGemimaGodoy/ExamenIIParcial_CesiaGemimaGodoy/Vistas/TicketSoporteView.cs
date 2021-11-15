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
    public partial class TicketSoporteView : Form
    {
        public TicketSoporteView()
        {
            InitializeComponent();
            TicketController controlador = new TicketController(this);
        }
    }
}
