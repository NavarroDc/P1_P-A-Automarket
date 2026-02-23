namespace CapaPresentacion
{
    partial class FormConsultarVendedor
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
            btnAtras = new Button();
            dgvConsultarVendedores = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Identificacion = new DataGridViewTextBoxColumn();
            NombreCompleto = new DataGridViewTextBoxColumn();
            FechaNacimiento = new DataGridViewTextBoxColumn();
            FechaIngreso = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvConsultarVendedores).BeginInit();
            SuspendLayout();
            // 
            // btnAtras
            // 
            btnAtras.Location = new Point(713, 415);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(75, 23);
            btnAtras.TabIndex = 0;
            btnAtras.Text = "Atrás";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // dgvConsultarVendedores
            // 
            dgvConsultarVendedores.AllowUserToAddRows = false;
            dgvConsultarVendedores.AllowUserToDeleteRows = false;
            dgvConsultarVendedores.AllowUserToResizeColumns = false;
            dgvConsultarVendedores.AllowUserToResizeRows = false;
            dgvConsultarVendedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvConsultarVendedores.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvConsultarVendedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultarVendedores.Columns.AddRange(new DataGridViewColumn[] { ID, Identificacion, NombreCompleto, FechaNacimiento, FechaIngreso, Telefono });
            dgvConsultarVendedores.Location = new Point(12, 12);
            dgvConsultarVendedores.Name = "dgvConsultarVendedores";
            dgvConsultarVendedores.Size = new Size(759, 389);
            dgvConsultarVendedores.TabIndex = 1;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // Identificacion
            // 
            Identificacion.HeaderText = "Identificación";
            Identificacion.Name = "Identificacion";
            Identificacion.ReadOnly = true;
            // 
            // NombreCompleto
            // 
            NombreCompleto.HeaderText = "Nombre completo";
            NombreCompleto.Name = "NombreCompleto";
            NombreCompleto.ReadOnly = true;
            // 
            // FechaNacimiento
            // 
            FechaNacimiento.HeaderText = "Fecha Nacimiento";
            FechaNacimiento.Name = "FechaNacimiento";
            FechaNacimiento.ReadOnly = true;
            // 
            // FechaIngreso
            // 
            FechaIngreso.HeaderText = "Fecha Ingreso";
            FechaIngreso.Name = "FechaIngreso";
            FechaIngreso.ReadOnly = true;
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Teléfono";
            Telefono.Name = "Telefono";
            Telefono.ReadOnly = true;
            // 
            // FormConsultarVendedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvConsultarVendedores);
            Controls.Add(btnAtras);
            Name = "FormConsultarVendedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormConsultarVendedor";
            Load += FormConsultarVendedor_Load;
            ((System.ComponentModel.ISupportInitialize)dgvConsultarVendedores).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAtras;
        private DataGridView dgvConsultarVendedores;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Identificacion;
        private DataGridViewTextBoxColumn NombreCompleto;
        private DataGridViewTextBoxColumn FechaNacimiento;
        private DataGridViewTextBoxColumn FechaIngreso;
        private DataGridViewTextBoxColumn Telefono;
    }
}