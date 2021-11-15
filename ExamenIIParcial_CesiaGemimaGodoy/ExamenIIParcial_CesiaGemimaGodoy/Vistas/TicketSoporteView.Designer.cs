
namespace ExamenIIParcial_CesiaGemimaGodoy.Vistas
{
    partial class TicketSoporteView
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
            this.IdTicketTextBox = new System.Windows.Forms.TextBox();
            this.IdClienteTextBox = new System.Windows.Forms.TextBox();
            this.PrecioTextBox = new System.Windows.Forms.TextBox();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.ModificarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.TicketDataGridView = new System.Windows.Forms.DataGridView();
            this.FechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TicketDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID TICKET";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "FECHA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID DEL CLIENTE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "PRECIO";
            // 
            // IdTicketTextBox
            // 
            this.IdTicketTextBox.Location = new System.Drawing.Point(158, 27);
            this.IdTicketTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IdTicketTextBox.Name = "IdTicketTextBox";
            this.IdTicketTextBox.ReadOnly = true;
            this.IdTicketTextBox.Size = new System.Drawing.Size(143, 25);
            this.IdTicketTextBox.TabIndex = 4;
            // 
            // IdClienteTextBox
            // 
            this.IdClienteTextBox.Location = new System.Drawing.Point(158, 126);
            this.IdClienteTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IdClienteTextBox.Name = "IdClienteTextBox";
            this.IdClienteTextBox.Size = new System.Drawing.Size(650, 25);
            this.IdClienteTextBox.TabIndex = 6;
            // 
            // PrecioTextBox
            // 
            this.PrecioTextBox.Location = new System.Drawing.Point(158, 178);
            this.PrecioTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PrecioTextBox.Name = "PrecioTextBox";
            this.PrecioTextBox.Size = new System.Drawing.Size(650, 25);
            this.PrecioTextBox.TabIndex = 7;
            // 
            // CancelarButton
            // 
            this.CancelarButton.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CancelarButton.Location = new System.Drawing.Point(692, 236);
            this.CancelarButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(117, 55);
            this.CancelarButton.TabIndex = 24;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            // 
            // EliminarButton
            // 
            this.EliminarButton.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EliminarButton.Location = new System.Drawing.Point(562, 236);
            this.EliminarButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(117, 55);
            this.EliminarButton.TabIndex = 23;
            this.EliminarButton.Text = "Limpiar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            // 
            // GuardarButton
            // 
            this.GuardarButton.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GuardarButton.Location = new System.Drawing.Point(427, 236);
            this.GuardarButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(117, 55);
            this.GuardarButton.TabIndex = 22;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            // 
            // ModificarButton
            // 
            this.ModificarButton.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ModificarButton.Location = new System.Drawing.Point(293, 236);
            this.ModificarButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ModificarButton.Name = "ModificarButton";
            this.ModificarButton.Size = new System.Drawing.Size(117, 55);
            this.ModificarButton.TabIndex = 21;
            this.ModificarButton.Text = "Modificar";
            this.ModificarButton.UseVisualStyleBackColor = true;
            // 
            // NuevoButton
            // 
            this.NuevoButton.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NuevoButton.Location = new System.Drawing.Point(163, 236);
            this.NuevoButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(117, 55);
            this.NuevoButton.TabIndex = 20;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.UseVisualStyleBackColor = true;
            // 
            // TicketDataGridView
            // 
            this.TicketDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TicketDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TicketDataGridView.Location = new System.Drawing.Point(-2, 316);
            this.TicketDataGridView.Name = "TicketDataGridView";
            this.TicketDataGridView.RowTemplate.Height = 25;
            this.TicketDataGridView.Size = new System.Drawing.Size(867, 150);
            this.TicketDataGridView.TabIndex = 25;
            // 
            // FechaDateTimePicker
            // 
            this.FechaDateTimePicker.Location = new System.Drawing.Point(158, 75);
            this.FechaDateTimePicker.Name = "FechaDateTimePicker";
            this.FechaDateTimePicker.Size = new System.Drawing.Size(291, 25);
            this.FechaDateTimePicker.TabIndex = 26;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // TicketSoporteView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 465);
            this.Controls.Add(this.FechaDateTimePicker);
            this.Controls.Add(this.TicketDataGridView);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.ModificarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.PrecioTextBox);
            this.Controls.Add(this.IdClienteTextBox);
            this.Controls.Add(this.IdTicketTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TicketSoporteView";
            this.Text = "Ticket de Soporte";
            ((System.ComponentModel.ISupportInitialize)(this.TicketDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox IdTicketTextBox;
        public System.Windows.Forms.TextBox IdClienteTextBox;
        public System.Windows.Forms.TextBox PrecioTextBox;
        public System.Windows.Forms.Button CancelarButton;
        public System.Windows.Forms.Button EliminarButton;
        public System.Windows.Forms.Button GuardarButton;
        public System.Windows.Forms.Button ModificarButton;
        public System.Windows.Forms.Button NuevoButton;
        public System.Windows.Forms.DataGridView TicketDataGridView;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.DateTimePicker FechaDateTimePicker;
        public System.Windows.Forms.ErrorProvider errorProvider1;
    }
}