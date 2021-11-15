using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ExamenIIParcial_CesiaGemimaGodoy.Vistas
{
    public partial class MenuWiew : Syncfusion.Windows.Forms.Office2010Form
    {
        public MenuWiew()
        {
            InitializeComponent();
        }

        private void listaDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuarioView vista = new UsuarioView();
            vista.MdiParent = this;
            vista.Show();
        }

        private void listaDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClienteView vista = new ClienteView();
            vista.MdiParent = this;
            vista.Show();
        }

        private void tiposDeServiciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipoSoporteView vista = new TipoSoporteView();
            vista.MdiParent = this;
            vista.Show();
        }

        private void listaDeEstadoDeTicketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EstadoTicketView vista = new EstadoTicketView();
            vista.MdiParent = this;
            vista.Show();
        }

        private void listaDeTicketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TicketSoporteView vista = new TicketSoporteView();
            vista.MdiParent = this;
            vista.Show();
        }

        private void detalleDeTicketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DetalleTicketView vista = new DetalleTicketView();
            vista.MdiParent = this;
            vista.Show();
            
        }
    }
}
