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
    public class TipoSoporteController
    {
        TipoSoporteView vista;
        string operacion = string.Empty;
        TipoSoporteDAO tipoSoporteDAO = new TipoSoporteDAO();
        TipoSoporte tipo = new TipoSoporte();

        public TipoSoporteController(TipoSoporteView view)
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
            if (vista.TipoSoporteDataGridView.SelectedRows.Count > 0)
            {
                bool elimino = tipoSoporteDAO.EliminarTipoSoporte(Convert.ToInt32(vista.TipoSoporteDataGridView.CurrentRow.Cells[0].Value.ToString()));

                if (elimino)
                {
                    DesabilitarControles();
                    LimpiarControles();

                    MessageBox.Show("TipoSoporte Eliminado Exitosamente", "Atención", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    ListarTipoSoporte();
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

            if (vista.TipoSoporteDataGridView.SelectedRows.Count > 0)
            {
                vista.IdTextBox.Text = vista.TipoSoporteDataGridView.CurrentRow.Cells["ID"].Value.ToString();
                vista.TipoSoporteComboBox.Text = vista.TipoSoporteDataGridView.CurrentRow.Cells["TIPOSOPORTE"].Value.ToString();
               

                HabilitarControles();
            }
        }

        private void Load(object serder, EventArgs e)
        {
            ListarTipoSoporte();
        }

        private void Guardar(object serder, EventArgs e)
        {
            if (vista.TipoSoporteComboBox.Text == "")
            {
                vista.errorProvider1.SetError(vista.TipoSoporteComboBox, "Ingrese un tipo");
                vista.TipoSoporteComboBox.Focus();
                return;
            }

            tipo.TipoSoportes = vista.TipoSoporteComboBox.Text;
            


            if (operacion == "Nuevo")
            {
                bool inserto = tipoSoporteDAO.InsertarNuevoTipoSoporte(tipo);

                if (inserto)
                {
                    DesabilitarControles();
                    LimpiarControles();

                    MessageBox.Show("Tipo de Soporte Creado Exitosamente", "Atención", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    ListarTipoSoporte();
                }
                else
                {
                    MessageBox.Show("No se pudo insertar el tipo de soporte", "Atención", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            else if (operacion == "Modificar")
            {
                tipo.IdTipo = Convert.ToInt32(vista.IdTextBox.Text);
                bool modifico = tipoSoporteDAO.ActualizarTipoSoporte(tipo);
                if (modifico)
                {
                    DesabilitarControles();
                    LimpiarControles();

                    MessageBox.Show("Tipo de Soporte Modificado Exitosamente", "Atención", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    ListarTipoSoporte();
                }
                else
                {
                    MessageBox.Show("No se pudo modificar el Tipo de Soporte", "Atención", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }



        }
        private void ListarTipoSoporte()
        {
            vista.TipoSoporteDataGridView.DataSource = tipoSoporteDAO.GetTipoSoporte();
        }


        private void LimpiarControles()
        {
            vista.IdTextBox.Clear();
            vista.TipoSoporteComboBox.Text = ""; ;
        }

        private void HabilitarControles()
        {
            vista.IdTextBox.Enabled = true;
            vista.TipoSoporteComboBox.Enabled = true;

            vista.GuardarButton.Enabled = true;
            vista.CancelarButton.Enabled = true;
            vista.ModificarButton.Enabled = false;
            vista.NuevoButton.Enabled = false;
        }
        private void DesabilitarControles()
        {
            vista.IdTextBox.Enabled = false;
            vista.TipoSoporteComboBox.Enabled = false;

            vista.GuardarButton.Enabled = false;
            vista.CancelarButton.Enabled = false;
            vista.ModificarButton.Enabled = true;
            vista.NuevoButton.Enabled = true;
        }
    }
}
