namespace CapaPresentacion
{
    partial class FormRegistrarVehiculo
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtIdVehiculo = new TextBox();
            txtMarcaVehiculo = new TextBox();
            txtModeloCarro = new TextBox();
            txtAnioVehiculo = new TextBox();
            txtPrecioVehiculo = new TextBox();
            cmbCategoriaVehiculo = new ComboBox();
            txtEstadoVehiculo = new TextBox();
            btnGuardar = new Button();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(138, 15);
            label1.TabIndex = 1;
            label1.Text = "Ingrese el ID del vehículo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 65);
            label2.Name = "label2";
            label2.Size = new Size(160, 15);
            label2.TabIndex = 2;
            label2.Text = "Ingrese la marca del vehículo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 108);
            label3.Name = "label3";
            label3.Size = new Size(168, 15);
            label3.TabIndex = 3;
            label3.Text = "Ingrese el modelo del vehículo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 152);
            label4.Name = "label4";
            label4.Size = new Size(147, 15);
            label4.TabIndex = 4;
            label4.Text = "Ingrese el año del vehículo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 200);
            label5.Name = "label5";
            label5.Size = new Size(160, 15);
            label5.TabIndex = 5;
            label5.Text = "Ingrese el precio del vehículo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 247);
            label6.Name = "label6";
            label6.Size = new Size(176, 15);
            label6.TabIndex = 6;
            label6.Text = "Ingrese la categoría del vehículo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 298);
            label7.Name = "label7";
            label7.Size = new Size(195, 15);
            label7.TabIndex = 7;
            label7.Text = "Ingrese el estado del vehículo (N/U)";
            // 
            // txtIdVehiculo
            // 
            txtIdVehiculo.Location = new Point(164, 17);
            txtIdVehiculo.Name = "txtIdVehiculo";
            txtIdVehiculo.Size = new Size(180, 23);
            txtIdVehiculo.TabIndex = 8;
            // 
            // txtMarcaVehiculo
            // 
            txtMarcaVehiculo.Location = new Point(186, 62);
            txtMarcaVehiculo.Name = "txtMarcaVehiculo";
            txtMarcaVehiculo.Size = new Size(158, 23);
            txtMarcaVehiculo.TabIndex = 9;
            // 
            // txtModeloCarro
            // 
            txtModeloCarro.Location = new Point(186, 105);
            txtModeloCarro.Name = "txtModeloCarro";
            txtModeloCarro.Size = new Size(168, 23);
            txtModeloCarro.TabIndex = 10;
            // 
            // txtAnioVehiculo
            // 
            txtAnioVehiculo.Location = new Point(173, 149);
            txtAnioVehiculo.Name = "txtAnioVehiculo";
            txtAnioVehiculo.Size = new Size(171, 23);
            txtAnioVehiculo.TabIndex = 11;
            // 
            // txtPrecioVehiculo
            // 
            txtPrecioVehiculo.Location = new Point(186, 200);
            txtPrecioVehiculo.Name = "txtPrecioVehiculo";
            txtPrecioVehiculo.Size = new Size(158, 23);
            txtPrecioVehiculo.TabIndex = 12;
            // 
            // cmbCategoriaVehiculo
            // 
            cmbCategoriaVehiculo.FormattingEnabled = true;
            cmbCategoriaVehiculo.Location = new Point(202, 244);
            cmbCategoriaVehiculo.Name = "cmbCategoriaVehiculo";
            cmbCategoriaVehiculo.Size = new Size(142, 23);
            cmbCategoriaVehiculo.TabIndex = 13;
            // 
            // txtEstadoVehiculo
            // 
            txtEstadoVehiculo.Location = new Point(221, 295);
            txtEstadoVehiculo.Name = "txtEstadoVehiculo";
            txtEstadoVehiculo.Size = new Size(123, 23);
            txtEstadoVehiculo.TabIndex = 14;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(20, 355);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 15;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // FormRegistrarVehiculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGuardar);
            Controls.Add(txtEstadoVehiculo);
            Controls.Add(cmbCategoriaVehiculo);
            Controls.Add(txtPrecioVehiculo);
            Controls.Add(txtAnioVehiculo);
            Controls.Add(txtModeloCarro);
            Controls.Add(txtMarcaVehiculo);
            Controls.Add(txtIdVehiculo);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAtras);
            Name = "FormRegistrarVehiculo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormRegistrarVehiculo";
            Load += FormRegistrarVehiculo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAtras;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtIdVehiculo;
        private TextBox txtMarcaVehiculo;
        private TextBox txtModeloCarro;
        private TextBox txtAnioVehiculo;
        private TextBox txtPrecioVehiculo;
        private ComboBox cmbCategoriaVehiculo;
        private TextBox txtEstadoVehiculo;
        private Button btnGuardar;
    }
}