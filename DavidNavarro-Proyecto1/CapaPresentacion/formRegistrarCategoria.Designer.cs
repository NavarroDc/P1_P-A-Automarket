namespace CapaPresentacion
{
    partial class formRegistrarCategoria
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
            txtIdCategoria = new TextBox();
            label2 = new Label();
            txtNombreCategoria = new TextBox();
            label3 = new Label();
            txtDescripcionCat = new TextBox();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // btnAtras
            // 
            btnAtras.Location = new Point(711, 410);
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
            label1.Location = new Point(23, 26);
            label1.Name = "label1";
            label1.Size = new Size(151, 15);
            label1.TabIndex = 1;
            label1.Text = "Ingrese el ID de la categoría";
            // 
            // txtIdCategoria
            // 
            txtIdCategoria.Location = new Point(193, 26);
            txtIdCategoria.Name = "txtIdCategoria";
            txtIdCategoria.Size = new Size(136, 23);
            txtIdCategoria.TabIndex = 2;
            txtIdCategoria.TextChanged += txtIdCategoria_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 96);
            label2.Name = "label2";
            label2.Size = new Size(182, 15);
            label2.TabIndex = 3;
            label2.Text = "Ingrese el nombre de la categoría";
            // 
            // txtNombreCategoria
            // 
            txtNombreCategoria.Location = new Point(220, 96);
            txtNombreCategoria.Name = "txtNombreCategoria";
            txtNombreCategoria.Size = new Size(136, 23);
            txtNombreCategoria.TabIndex = 4;
            txtNombreCategoria.TextChanged += txtNombreCategoria_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 168);
            label3.Name = "label3";
            label3.Size = new Size(201, 15);
            label3.TabIndex = 5;
            label3.Text = "Ingrese la descripción de la categoría";
            // 
            // txtDescripcionCat
            // 
            txtDescripcionCat.Location = new Point(239, 168);
            txtDescripcionCat.Name = "txtDescripcionCat";
            txtDescripcionCat.Size = new Size(135, 23);
            txtDescripcionCat.TabIndex = 6;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(23, 244);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // formRegistrarCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGuardar);
            Controls.Add(txtDescripcionCat);
            Controls.Add(label3);
            Controls.Add(txtNombreCategoria);
            Controls.Add(label2);
            Controls.Add(txtIdCategoria);
            Controls.Add(label1);
            Controls.Add(btnAtras);
            Name = "formRegistrarCategoria";
            Text = "formRegistrarCategoria";
            Load += formRegistrarCategoria_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAtras;
        private Label label1;
        private TextBox txtIdCategoria;
        private Label label2;
        private TextBox txtNombreCategoria;
        private Label label3;
        private TextBox txtDescripcionCat;
        private Button btnGuardar;
    }
}