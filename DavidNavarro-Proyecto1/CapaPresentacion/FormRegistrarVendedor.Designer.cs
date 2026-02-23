namespace CapaPresentacion
{
    partial class FormRegistrarVendedor
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
            dtpFechaNacimiento = new DateTimePicker();
            label5 = new Label();
            dtpFechaIngreso = new DateTimePicker();
            label6 = new Label();
            txtIdVendedor = new TextBox();
            txtIdentificacionVendedor = new TextBox();
            txtNombreVendedor = new TextBox();
            txtTelefonoVendedor = new TextBox();
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
            label1.Location = new Point(23, 20);
            label1.Name = "label1";
            label1.Size = new Size(143, 15);
            label1.TabIndex = 1;
            label1.Text = "Ingrese el ID del vendedor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 66);
            label2.Name = "label2";
            label2.Size = new Size(204, 15);
            label2.TabIndex = 2;
            label2.Text = "Ingrese la identificación del vendedor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 112);
            label3.Name = "label3";
            label3.Size = new Size(228, 15);
            label3.TabIndex = 3;
            label3.Text = "Ingrese el nombre completo del vendedor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 170);
            label4.Name = "label4";
            label4.Size = new Size(240, 15);
            label4.TabIndex = 4;
            label4.Text = "Ingrese la fecha de nacimiento del vendedor";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Format = DateTimePickerFormat.Short;
            dtpFechaNacimiento.Location = new Point(269, 164);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(200, 23);
            dtpFechaNacimiento.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 213);
            label5.Name = "label5";
            label5.Size = new Size(219, 15);
            label5.TabIndex = 6;
            label5.Text = "Ingrese la fecha de ingreso del vendedor";
            // 
            // dtpFechaIngreso
            // 
            dtpFechaIngreso.Format = DateTimePickerFormat.Short;
            dtpFechaIngreso.Location = new Point(248, 213);
            dtpFechaIngreso.Name = "dtpFechaIngreso";
            dtpFechaIngreso.Size = new Size(200, 23);
            dtpFechaIngreso.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 277);
            label6.Name = "label6";
            label6.Size = new Size(176, 15);
            label6.TabIndex = 8;
            label6.Text = "Ingrese el teléfono del vendedor";
            // 
            // txtIdVendedor
            // 
            txtIdVendedor.Location = new Point(172, 17);
            txtIdVendedor.Name = "txtIdVendedor";
            txtIdVendedor.Size = new Size(141, 23);
            txtIdVendedor.TabIndex = 9;
            // 
            // txtIdentificacionVendedor
            // 
            txtIdentificacionVendedor.Location = new Point(233, 63);
            txtIdentificacionVendedor.Name = "txtIdentificacionVendedor";
            txtIdentificacionVendedor.Size = new Size(122, 23);
            txtIdentificacionVendedor.TabIndex = 10;
            // 
            // txtNombreVendedor
            // 
            txtNombreVendedor.Location = new Point(257, 109);
            txtNombreVendedor.Name = "txtNombreVendedor";
            txtNombreVendedor.Size = new Size(123, 23);
            txtNombreVendedor.TabIndex = 11;
            txtNombreVendedor.TextChanged += textBox1_TextChanged;
            // 
            // txtTelefonoVendedor
            // 
            txtTelefonoVendedor.Location = new Point(205, 277);
            txtTelefonoVendedor.Name = "txtTelefonoVendedor";
            txtTelefonoVendedor.Size = new Size(158, 23);
            txtTelefonoVendedor.TabIndex = 12;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(23, 381);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 13;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // FormRegistrarVendedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGuardar);
            Controls.Add(txtTelefonoVendedor);
            Controls.Add(txtNombreVendedor);
            Controls.Add(txtIdentificacionVendedor);
            Controls.Add(txtIdVendedor);
            Controls.Add(label6);
            Controls.Add(dtpFechaIngreso);
            Controls.Add(label5);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAtras);
            Name = "FormRegistrarVendedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormRegistrarVendedor";
            Load += FormRegistrarVendedor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAtras;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dtpFechaNacimiento;
        private Label label5;
        private DateTimePicker dtpFechaIngreso;
        private Label label6;
        private TextBox txtIdVendedor;
        private TextBox txtIdentificacionVendedor;
        private TextBox txtNombreVendedor;
        private TextBox txtTelefonoVendedor;
        private Button btnGuardar;
    }
}