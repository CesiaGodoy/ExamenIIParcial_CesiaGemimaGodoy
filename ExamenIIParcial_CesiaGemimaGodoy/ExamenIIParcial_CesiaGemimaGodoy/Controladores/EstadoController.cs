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
    public class EstadoController
    {
        EstadoTicketView vista;
        string operacion = string.Empty;
        EstadoDAO userDAO = new EstadoDAO();
        Estado estado = new Estado();

        public EstadoController(EstadoTicketView view)
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
            if (vista.EstadoTicketDataGridView.SelectedRows.Count > 0)
            {
                bool elimino = userDAO.EliminarEstado(Convert.ToInt32(vista.EstadoTicketDataGridView.CurrentRow.Cells[0].Value.ToString()));

                if (elimino)
                {
                    DesabilitarControles();
                    LimpiarControles();

                    MessageBox.Show("Estado Eliminado Exitosamente", "Atención", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    ListarUsuarios();
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

            if (vista.EstadoTicketDataGridView.SelectedRows.Count > 0)
            {
                vista.IdEstadoTextBox.Text = vista.EstadoTicketDataGridView.CurrentRow.Cells["ID"].Value.ToString();
                vista.EstadoTicektComboBox.Text = vista.EstadoTicketDataGridView.CurrentRow.Cells["ESTADOTICKET"].Value.ToString();
                vista.IdClienteTextBox.Text = vista.EstadoTicketDataGridView.CurrentRow.Cells["IDCLIENTE"].Value.ToString();

                HabilitarControles();
            }
        }

        private void Load(object serder, EventArgs e)
        {
            ListarUsuarios();
        }

        private void Guardar(object serder, EventArgs e)
        {
            if (vista.EstadoTicektComboBox.Text == "")
            {
                vista.errorProvider1.SetError(vista.EstadoTicektComboBox, "Ingrese un estado");
                vista.EstadoTicektComboBox.Focus();
                return;
            }
            if (vista.IdClienteTextBox.Text == "")
            {
                vista.errorProvider1.SetError(vista.IdClienteTextBox, "Ingrese un IdCliente");
                vista.IdClienteTextBox.Focus();
                return;
            }

            estado.EstadoTicket = vista.EstadoTicektComboBox.Text;
            estado.IdCliente = Convert.ToInt32( vista.IdClienteTextBox.Text);
           

            if (operacion == "Nuevo")
            {
                bool inserto = userDAO.InsertarNuevoEstado(estado);

                if (inserto)
                {
                    DesabilitarControles();
                    LimpiarControles();

                    MessageBox.Show("Estado Creado Exitosamente", "Atención", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    ListarUsuarios();
                }
                else
                {
                    MessageBox.Show("No se pudo insertar el estado", "Atención", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            else if (operacion == "Modificar")
            {
                estado.IdEstado = Convert.ToInt32(vista.IdEstadoTextBox.Text);
                bool modifico = userDAO.ActualizarEstado(estado);
                if (modifico)
                {
                    DesabilitarControles();
                    LimpiarControles();

                    MessageBox.Show("Usuario Modificado Exitosamente", "Atención", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    ListarUsuarios();
                }
                else
                {
                    MessageBox.Show("No se pudo modificar el usuario", "Atención", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }



        }
        private void ListarUsuarios()
        {
            vista.EstadoTicketDataGridView.DataSource = userDAO.GetEstados();
        }


        private void LimpiarControles()
        {
            vista.IdEstadoTextBox.Clear();
            vista.EstadoTicektComboBox.Text = "";
            vista.IdClienteTextBox.Clear();
        }

        private void HabilitarControles()
        {
            vista.IdEstadoTextBox.Enabled = true;
            vista.EstadoTicektComboBox.Enabled = true;
            vista.IdClienteTextBox.Enabled = true;
           
            vista.GuardarButton.Enabled = true;
            vista.CancelarButton.Enabled = true;
            vista.ModificarButton.Enabled = false;
            vista.NuevoButton.Enabled = false;
        }
        private void DesabilitarControles()
        {
            vista.IdEstadoTextBox.Enabled = false;
            vista.EstadoTicektComboBox.Enabled = false;
            vista.IdClienteTextBox.Enabled = false;

            vista.GuardarButton.Enabled = false;
            vista.CancelarButton.Enabled = false;
            vista.ModificarButton.Enabled = true;
            vista.NuevoButton.Enabled = true;
        }
    }
}

