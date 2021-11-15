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
    public class UsuarioController
    {
        UsuarioView vista;
        string operacion = string.Empty;
        UsuarioDAO userDAO = new UsuarioDAO();
        Usuario user = new Usuario();

        public UsuarioController(UsuarioView view)
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
            if (vista.UsuarioDataGridView.SelectedRows.Count > 0)
            {
                bool elimino = userDAO.EliminarUsuario(Convert.ToInt32(vista.UsuarioDataGridView.CurrentRow.Cells[0].Value.ToString()));

                if (elimino)
                {
                    DesabilitarControles();
                    LimpiarControles();

                    MessageBox.Show("Usuario Eliminado Exitosamente", "Atención", MessageBoxButtons.OK,
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

            if (vista.UsuarioDataGridView.SelectedRows.Count > 0)
            {
                vista.IdTextBox.Text = vista.UsuarioDataGridView.CurrentRow.Cells["ID"].Value.ToString();
                vista.NombreTextBox.Text = vista.UsuarioDataGridView.CurrentRow.Cells["NOMBRE"].Value.ToString();
                vista.EmailTextBox.Text = vista.UsuarioDataGridView.CurrentRow.Cells["EMAIL"].Value.ToString();
                vista.EsAdministradorCheckBox.Checked = Convert.ToBoolean(vista.UsuarioDataGridView.CurrentRow.Cells["ESADMINISTRADOR"].Value);

                HabilitarControles();
            }
        }

        private void Load(object serder, EventArgs e)
        {
            ListarUsuarios();
        }

        private void Guardar(object serder, EventArgs e)
        {
            if (vista.NombreTextBox.Text == "")
            {
                vista.errorProvider1.SetError(vista.NombreTextBox, "Ingrese un nombre");
                vista.NombreTextBox.Focus();
                return;
            }
            if (vista.EmailTextBox.Text == "")
            {
                vista.errorProvider1.SetError(vista.EmailTextBox, "Ingrese un email");
                vista.EmailTextBox.Focus();
                return;
            }
            if (vista.ClaveTextBox.Text == "")
            {
                vista.errorProvider1.SetError(vista.ClaveTextBox, "Ingrese una clave");
                vista.ClaveTextBox.Focus();
                return;
            }

            user.Nombre = vista.NombreTextBox.Text;
            user.Email = vista.EmailTextBox.Text;
            user.Clave = vista.ClaveTextBox.Text;
            user.EsAdministrador = vista.EsAdministradorCheckBox.Checked;

            if (operacion == "Nuevo")
            {
                bool inserto = userDAO.InsertarNuevoUsuario(user);

                if (inserto)
                {
                    DesabilitarControles();
                    LimpiarControles();

                    MessageBox.Show("Usuario Creado Exitosamente", "Atención", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    ListarUsuarios();
                }
                else
                {
                    MessageBox.Show("No se pudo insertar el usuario", "Atención", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            else if (operacion == "Modificar")
            {
                user.Id = Convert.ToInt32(vista.IdTextBox.Text);
                bool modifico = userDAO.ActualizarUsuario(user);
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
            vista.UsuarioDataGridView.DataSource = userDAO.GetUsuarios();
        }


        private void LimpiarControles()
        {
            vista.IdTextBox.Clear();
            vista.NombreTextBox.Clear();
            vista.EmailTextBox.Clear();
            vista.ClaveTextBox.Clear();
            vista.EsAdministradorCheckBox.Enabled = false;
        }

        private void HabilitarControles()
        {
            vista.IdTextBox.Enabled = true;
            vista.NombreTextBox.Enabled = true;
            vista.EmailTextBox.Enabled = true;
            vista.ClaveTextBox.Enabled = true;
            vista.EsAdministradorCheckBox.Enabled = true;

            vista.GuardarButton.Enabled = true;
            vista.CancelarButton.Enabled = true;
            vista.ModificarButton.Enabled = false;
            vista.NuevoButton.Enabled = false;
        }
        private void DesabilitarControles()
        {
            vista.IdTextBox.Enabled = false;
            vista.NombreTextBox.Enabled = false;
            vista.EmailTextBox.Enabled = false;
            vista.ClaveTextBox.Enabled = false;
            vista.EsAdministradorCheckBox.Enabled = false;

            vista.GuardarButton.Enabled = false;
            vista.CancelarButton.Enabled = false;
            vista.ModificarButton.Enabled = true;
            vista.NuevoButton.Enabled = true;
        }
    }
}

