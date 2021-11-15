using ExamenIIParcial_CesiaGemimaGodoy.Modelos.DAO;
using ExamenIIParcial_CesiaGemimaGodoy.Modelos.Entidades;
using ExamenIIParcial_CesiaGemimaGodoy.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenIIParcial_CesiaGemimaGodoy.Controladores
{
    public class TicketController
    {
        TicketSoporteView vista;
        string operacion = string.Empty;
        TicketSoporteDAO ticketDAO = new TicketSoporteDAO();
        Ticket ticket = new Ticket();

        public TicketController(TicketSoporteView view)
        {
            vista = view;
            vista.NuevoButton.Click += new EventHandler(Nuevo);
            vista.GuardarButton.Click += new EventHandler(Guardar);
            vista.Load += new EventHandler(Load);
            vista.ModificarButton.Click += new EventHandler(Modificar);
            vista.EliminarButton.Click += new EventHandler(Eliminar);

        }


        private void Eliminar(object serder, EventArgs e)
        {
            if (vista.TicketDataGridView.SelectedRows.Count > 0)
            {
                bool elimino = ticketDAO.EliminarTicket(Convert.ToInt32(vista.TicketDataGridView.CurrentRow.Cells[0].Value.ToString()));

                if (elimino)
                {
                    DesabilitarControles();
                    LimpiarControles();

                    MessageBox.Show("Ticket Eliminado Exitosamente", "Atención", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    ListarTicket();
                }
            }
        }
        private void Nuevo(object serder, EventArgs e)
        {
            HabilitarControles();
            operacion = "Nuevo";
        }
        private void Modificar(object serder, EventArgs e)
        {
            operacion = "Modificar";

            if (vista.TicketDataGridView.SelectedRows.Count > 0)
            {
                vista.IdTicketTextBox.Text = vista.TicketDataGridView.CurrentRow.Cells["IDTICKET"].Value.ToString();
                vista.FechaDateTimePicker.Text = vista.TicketDataGridView.CurrentRow.Cells["FECHA"].Value.ToString();
                vista.IdClienteTextBox.Text = vista.TicketDataGridView.CurrentRow.Cells["IDCLIENTE"].Value.ToString();
                vista.PrecioTextBox.Text = vista.TicketDataGridView.CurrentRow.Cells["PRECIO"].Value.ToString();

                HabilitarControles();
            }
        }

        private void Load(object serder, EventArgs e)
        {
            ListarTicket();
        }

        private void Guardar(object serder, EventArgs e)
        {
            if (vista.FechaDateTimePicker.Text == "")
            {
                vista.errorProvider1.SetError(vista.FechaDateTimePicker, "Ingrese una fecha");
                vista.FechaDateTimePicker.Focus();
                return;
            }
            if (vista.IdClienteTextBox.Text == "")
            {
                vista.errorProvider1.SetError(vista.IdClienteTextBox, "Ingrese un Id cliente");
                vista.IdClienteTextBox.Focus();
                return;
            }
            if (vista.PrecioTextBox.Text == "")
            {
                vista.errorProvider1.SetError(vista.PrecioTextBox, "Ingrese una precio");
                vista.PrecioTextBox.Focus();
                return;
            }

            ticket.Fecha = vista.FechaDateTimePicker.Value;
            ticket.IdCliente = Convert.ToInt32(vista.IdClienteTextBox.Text);
            ticket.Precio = Convert.ToDecimal( vista.PrecioTextBox.Text);

            if (operacion == "Nuevo")
            {
                bool inserto = ticketDAO.InsertarNuevoTicket(ticket);

                if (inserto)
                {
                    DesabilitarControles();
                    LimpiarControles();

                    MessageBox.Show("Ticket Creado Exitosamente", "Atención", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    ListarTicket();
                }
                else
                {
                    MessageBox.Show("No se pudo insertar el Ticket", "Atención", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            else if (operacion == "Modificar")
            {
                ticket.IdTicket = Convert.ToInt32(vista.IdTicketTextBox.Text);
                bool modifico = ticketDAO.ActualizarTicket(ticket);
                if (modifico)
                {
                    DesabilitarControles();
                    LimpiarControles();

                    MessageBox.Show("Ticket Modificado Exitosamente", "Atención", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    ListarTicket();
                }
                else
                {
                    MessageBox.Show("No se pudo modificar el ticket", "Atención", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }



        }
        private void ListarTicket()
        {
            vista.TicketDataGridView.DataSource = ticketDAO.GetTickets();
        }


        private void LimpiarControles()
        {
            vista.IdTicketTextBox.Clear();
            //vista.FechaDateTimePicker.ca;
            vista.IdClienteTextBox.Clear();
            vista.PrecioTextBox.Clear();
        }

        private void HabilitarControles()
        {
            vista.IdTicketTextBox.Enabled = true;
            vista.FechaDateTimePicker.Enabled = true;
            vista.IdClienteTextBox.Enabled = true;
            vista.PrecioTextBox.Enabled = true;

            vista.GuardarButton.Enabled = true;
            vista.CancelarButton.Enabled = true;
            vista.ModificarButton.Enabled = false;
            vista.NuevoButton.Enabled = false;
        }
        private void DesabilitarControles()
        {
            vista.IdTicketTextBox.Enabled = false;
            vista.FechaDateTimePicker.Enabled = false;
            vista.IdClienteTextBox.Enabled = false;
            vista.PrecioTextBox.Enabled = false;

            vista.GuardarButton.Enabled = false;
            vista.CancelarButton.Enabled = false;
            vista.ModificarButton.Enabled = true;
            vista.NuevoButton.Enabled = true;
        }
    }
}
