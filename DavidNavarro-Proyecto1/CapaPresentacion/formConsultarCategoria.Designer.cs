namespace CapaPresentacion
{
    partial class formConsultarCategoria
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
            dgvCategoriasVehiculos = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Descripción = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvCategoriasVehiculos).BeginInit();
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
            // dgvCategoriasVehiculos
            // 
            dgvCategoriasVehiculos.AllowUserToAddRows = false;
            dgvCategoriasVehiculos.AllowUserToDeleteRows = false;
            dgvCategoriasVehiculos.AllowUserToResizeColumns = false;
            dgvCategoriasVehiculos.AllowUserToResizeRows = false;
            dgvCategoriasVehiculos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategoriasVehiculos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvCategoriasVehiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategoriasVehiculos.Columns.AddRange(new DataGridViewColumn[] { ID, Nombre, Descripción });
            dgvCategoriasVehiculos.Location = new Point(90, 12);
            dgvCategoriasVehiculos.Name = "dgvCategoriasVehiculos";
            dgvCategoriasVehiculos.ReadOnly = true;
            dgvCategoriasVehiculos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategoriasVehiculos.Size = new Size(605, 311);
            dgvCategoriasVehiculos.TabIndex = 1;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Descripción
            // 
            Descripción.HeaderText = "Descripción";
            Descripción.Name = "Descripción";
            Descripción.ReadOnly = true;
            // 
            // formConsultarCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvCategoriasVehiculos);
            Controls.Add(btnAtras);
            Name = "formConsultarCategoria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formConsultarCategoria";
            Load += formConsultarCategoria_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCategoriasVehiculos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAtras;
        private DataGridView dgvCategoriasVehiculos;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Descripción;
    }
}