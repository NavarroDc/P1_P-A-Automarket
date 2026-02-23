namespace CapaPresentacion
{
    partial class FormConsultarVehiculo
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
            dgvConsultarVehiculos = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Marca = new DataGridViewTextBoxColumn();
            Modelo = new DataGridViewTextBoxColumn();
            Año = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            NombreCategoria = new DataGridViewTextBoxColumn();
            DescripcionCategoria = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvConsultarVehiculos).BeginInit();
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
            // dgvConsultarVehiculos
            // 
            dgvConsultarVehiculos.AllowUserToAddRows = false;
            dgvConsultarVehiculos.AllowUserToDeleteRows = false;
            dgvConsultarVehiculos.AllowUserToResizeColumns = false;
            dgvConsultarVehiculos.AllowUserToResizeRows = false;
            dgvConsultarVehiculos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvConsultarVehiculos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvConsultarVehiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultarVehiculos.Columns.AddRange(new DataGridViewColumn[] { ID, Marca, Modelo, Año, Precio, NombreCategoria, DescripcionCategoria, Estado });
            dgvConsultarVehiculos.Location = new Point(42, 12);
            dgvConsultarVehiculos.Name = "dgvConsultarVehiculos";
            dgvConsultarVehiculos.Size = new Size(712, 351);
            dgvConsultarVehiculos.TabIndex = 1;
            dgvConsultarVehiculos.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // Marca
            // 
            Marca.HeaderText = "Marca";
            Marca.Name = "Marca";
            Marca.ReadOnly = true;
            // 
            // Modelo
            // 
            Modelo.HeaderText = "Modelo";
            Modelo.Name = "Modelo";
            Modelo.ReadOnly = true;
            // 
            // Año
            // 
            Año.HeaderText = "Año";
            Año.Name = "Año";
            Año.ReadOnly = true;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // NombreCategoria
            // 
            NombreCategoria.HeaderText = "Categoría(Nombre)";
            NombreCategoria.Name = "NombreCategoria";
            NombreCategoria.ReadOnly = true;
            // 
            // DescripcionCategoria
            // 
            DescripcionCategoria.HeaderText = "Categoria(Descripción)";
            DescripcionCategoria.Name = "DescripcionCategoria";
            DescripcionCategoria.ReadOnly = true;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            // 
            // FormConsultarVehiculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvConsultarVehiculos);
            Controls.Add(btnAtras);
            Name = "FormConsultarVehiculo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormConsultarVehiculo";
            Load += FormConsultarVehiculo_Load;
            ((System.ComponentModel.ISupportInitialize)dgvConsultarVehiculos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAtras;
        private DataGridView dgvConsultarVehiculos;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Marca;
        private DataGridViewTextBoxColumn Modelo;
        private DataGridViewTextBoxColumn Año;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn NombreCategoria;
        private DataGridViewTextBoxColumn DescripcionCategoria;
        private DataGridViewTextBoxColumn Estado;
    }
}