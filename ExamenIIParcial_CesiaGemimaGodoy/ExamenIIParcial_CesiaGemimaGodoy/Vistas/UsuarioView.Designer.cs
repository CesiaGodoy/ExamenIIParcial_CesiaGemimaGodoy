
namespace ExamenIIParcial_CesiaGemimaGodoy.Vistas
{
    partial class UsuarioView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EsAdministradorCheckBox = new System.Windows.Forms.CheckBox();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.ClaveTextBox = new System.Windows.Forms.TextBox();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.ModificarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.UsuarioDataGridView = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOMBRE:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "EMAIL:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "CLAVE:";
            // 
            // EsAdministradorCheckBox
            // 
            this.EsAdministradorCheckBox.AutoSize = true;
            this.EsAdministradorCheckBox.Enabled = false;
            this.EsAdministradorCheckBox.Location = new System.Drawing.Point(118, 212);
            this.EsAdministradorCheckBox.Name = "EsAdministradorCheckBox";
            this.EsAdministradorCheckBox.Size = new System.Drawing.Size(135, 19);
            this.EsAdministradorCheckBox.TabIndex = 4;
            this.EsAdministradorCheckBox.Text = "ES ADMINISTRADOR";
            this.EsAdministradorCheckBox.UseVisualStyleBackColor = true;
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(118, 20);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(120, 23);
            this.IdTextBox.TabIndex = 5;
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Enabled = false;
            this.NombreTextBox.Location = new System.Drawing.Point(118, 69);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(379, 23);
            this.NombreTextBox.TabIndex = 6;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Enabled = false;
            this.EmailTextBox.Location = new System.Drawing.Point(118, 116);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(379, 23);
            this.EmailTextBox.TabIndex = 7;
            // 
            // ClaveTextBox
            // 
            this.ClaveTextBox.Enabled = false;
            this.ClaveTextBox.Location = new System.Drawing.Point(118, 165);
            this.ClaveTextBox.Name = "ClaveTextBox";
            this.ClaveTextBox.Size = new System.Drawing.Size(379, 23);
            this.ClaveTextBox.TabIndex = 8;
            // 
            // CancelarButton
            // 
            this.CancelarButton.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CancelarButton.Location = new System.Drawing.Point(509, 245);
            this.CancelarButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(102, 46);
            this.CancelarButton.TabIndex = 19;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            // 
            // EliminarButton
            // 
            this.EliminarButton.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EliminarButton.Location = new System.Drawing.Point(395, 245);
            this.EliminarButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(102, 46);
            this.EliminarButton.TabIndex = 18;
            this.EliminarButton.Text = "Limpiar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            // 
            // GuardarButton
            // 
            this.GuardarButton.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GuardarButton.Location = new System.Drawing.Point(277, 245);
            this.GuardarButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(102, 46);
            this.GuardarButton.TabIndex = 17;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            // 
            // ModificarButton
            // 
            this.ModificarButton.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ModificarButton.Location = new System.Drawing.Point(160, 245);
            this.ModificarButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ModificarButton.Name = "ModificarButton";
            this.ModificarButton.Size = new System.Drawing.Size(102, 46);
            this.ModificarButton.TabIndex = 16;
            this.ModificarButton.Text = "Modificar";
            this.ModificarButton.UseVisualStyleBackColor = true;
            // 
            // NuevoButton
            // 
            this.NuevoButton.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NuevoButton.Location = new System.Drawing.Point(46, 245);
            this.NuevoButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(102, 46);
            this.NuevoButton.TabIndex = 15;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.UseVisualStyleBackColor = true;
            // 
            // UsuarioDataGridView
            // 
            this.UsuarioDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UsuarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsuarioDataGridView.Location = new System.Drawing.Point(-2, 309);
            this.UsuarioDataGridView.Name = "UsuarioDataGridView";
            this.UsuarioDataGridView.RowTemplate.Height = 25;
            this.UsuarioDataGridView.Size = new System.Drawing.Size(656, 150);
            this.UsuarioDataGridView.TabIndex = 20;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // UsuarioView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 454);
            this.Controls.Add(this.UsuarioDataGridView);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.ModificarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.ClaveTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.EsAdministradorCheckBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UsuarioView";
            this.Text = "UsuarioView";
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.CheckBox EsAdministradorCheckBox;
        public System.Windows.Forms.TextBox IdTextBox;
        public System.Windows.Forms.TextBox NombreTextBox;
        public System.Windows.Forms.TextBox EmailTextBox;
        public System.Windows.Forms.TextBox ClaveTextBox;
        public System.Windows.Forms.Button CancelarButton;
        public System.Windows.Forms.Button EliminarButton;
        public System.Windows.Forms.Button GuardarButton;
        public System.Windows.Forms.Button ModificarButton;
        public System.Windows.Forms.Button NuevoButton;
        public System.Windows.Forms.DataGridView UsuarioDataGridView;
        public System.Windows.Forms.ErrorProvider errorProvider1;
    }
}