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
    public class ClienteController
    {
        ClienteView vista;
        string operacion = string.Empty;
        ClienteDAO clientDAO = new ClienteDAO();
        Cliente client = new Cliente();

        public ClienteController(ClienteView view)
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
            if (vista.ClienteDataGridView.SelectedRows.Count > 0)
            {
                bool elimino = clientDAO.EliminarCliente(Convert.ToInt32(vista.ClienteDataGridView.CurrentRow.Cells[0].Value.ToString()));

                if (elimino)
                {
                    DesabilitarControles();
                    LimpiarControles();

                    MessageBox.Show("Cliente Eliminado Exitosamente", "Atención", MessageBoxButtons.OK,
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

            if (vista.ClienteDataGridView.SelectedRows.Count > 0)
            {
                vista.IdClienteTextBox.Text = vista.ClienteDataGridView.CurrentRow.Cells["ID"].Value.ToString();
                vista.NombreClienteTextBox.Text = vista.ClienteDataGridView.CurrentRow.Cells["NOMBRE"].Value.ToString();
                vista.EmailClienteTextBox.Text = vista.ClienteDataGridView.CurrentRow.Cells["EMAIL"].Value.ToString();
                vista.DireccionTextBox.Text = vista.ClienteDataGridView.CurrentRow.Cells["DIRECCION"].ToString();

                HabilitarControles();
            }
        }

        private void Load(object serder, EventArgs e)
        {
            ListarUsuarios();
        }

        private void Guardar(object serder, EventArgs e)
        {
            if (vista.NombreClienteTextBox.Text == "")
            {
                vista.errorProvider1.SetError(vista.NombreClienteTextBox, "Ingrese un nombre");
                vista.NombreClienteTextBox.Focus();
                return;
            }
            if (vista.EmailClienteTextBox.Text == "")
            {
                vista.errorProvider1.SetError(vista.EmailClienteTextBox, "Ingrese un email");
                vista.EmailClienteTextBox.Focus();
                return;
            }
            if (vista.DireccionTextBox.Text == "")
            {
                vista.errorProvider1.SetError(vista.DireccionTextBox, "Ingrese una dirección");
                vista.DireccionTextBox.Focus();
                return;
            }

            client.Nombre = vista.NombreClienteTextBox.Text;
            client.Email = vista.EmailClienteTextBox.Text;
            client.Direccion = vista.DireccionTextBox.Text;
   

            if (operacion == "Nuevo")
            {
                bool inserto = clientDAO.InsertarNuevoCliente(client);

                if (inserto)
                {
                    DesabilitarControles();
                    LimpiarControles();

                    MessageBox.Show("Cliente Creado Exitosamente", "Atención", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    ListarUsuarios();
                }
                else
                {
                    MessageBox.Show("No se pudo insertar el Cliente", "Atención", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            else if (operacion == "Modificar")
            {
                client.IdCliente = Convert.ToInt32(vista.IdClienteTextBox.Text);
                bool modifico = clientDAO.ActualizarCliente(client);
                if (modifico)
                {
                    DesabilitarControles();
                    LimpiarControles();

                    MessageBox.Show("Cliente Modificado Exitosamente", "Atención", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    ListarUsuarios();
                }
                else
                {
                    MessageBox.Show("No se pudo modificar el cliente", "Atención", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }



        }
        private void ListarUsuarios()
        {
            vista.ClienteDataGridView.DataSource = clientDAO.GetClientes();
        }


        private void LimpiarControles()
        {
            vista.IdClienteTextBox.Clear();
            vista.NombreClienteTextBox.Clear();
            vista.EmailClienteTextBox.Clear();
            vista.DireccionTextBox.Clear();
        }

        private void HabilitarControles()
        {
            vista.IdClienteTextBox.Enabled = true;
            vista.NombreClienteTextBox.Enabled = true;
            vista.EmailClienteTextBox.Enabled = true;
            vista.DireccionTextBox.Enabled = true;

            vista.GuardarButton.Enabled = true;
            vista.CancelarButton.Enabled = true;
            vista.ModificarButton.Enabled = false;
            vista.NuevoButton.Enabled = false;
        }
        private void DesabilitarControles()
        {
            vista.IdClienteTextBox.Enabled = false;
            vista.NombreClienteTextBox.Enabled = false;
            vista.EmailClienteTextBox.Enabled = false;
            vista.DireccionTextBox.Enabled = false;

            vista.GuardarButton.Enabled = false;
            vista.CancelarButton.Enabled = false;
            vista.ModificarButton.Enabled = true;
            vista.NuevoButton.Enabled = true;
        }
    }
}
