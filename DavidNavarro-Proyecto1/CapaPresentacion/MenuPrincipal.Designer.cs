namespace CapaPresentacion
{
    partial class MenuPrincipal
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
            label1 = new Label();
            label2 = new Label();
            btnRegistrarCategoria = new Button();
            btnConsultarCategoria = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(132, 9);
            label1.Name = "label1";
            label1.Size = new Size(94, 30);
            label1.TabIndex = 0;
            label1.Text = "Registrar";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(559, 9);
            label2.Name = "label2";
            label2.Size = new Size(101, 30);
            label2.TabIndex = 1;
            label2.Text = "Consultar";
            label2.Click += label2_Click;
            // 
            // btnRegistrarCategoria
            // 
            btnRegistrarCategoria.Location = new Point(101, 70);
            btnRegistrarCategoria.Name = "btnRegistrarCategoria";
            btnRegistrarCategoria.Size = new Size(147, 23);
            btnRegistrarCategoria.TabIndex = 2;
            btnRegistrarCategoria.Text = "Registrar categoría";
            btnRegistrarCategoria.UseVisualStyleBackColor = true;
            btnRegistrarCategoria.Click += btnRegistrarCategoria_Click;
            // 
            // btnConsultarCategoria
            // 
            btnConsultarCategoria.Location = new Point(538, 70);
            btnConsultarCategoria.Name = "btnConsultarCategoria";
            btnConsultarCategoria.Size = new Size(134, 23);
            btnConsultarCategoria.TabIndex = 3;
            btnConsultarCategoria.Text = "Consultar categoría";
            btnConsultarCategoria.UseVisualStyleBackColor = true;
            btnConsultarCategoria.Click += btnConsultarCategoria_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnConsultarCategoria);
            Controls.Add(btnRegistrarCategoria);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuPrincipal";
            Load += MenuPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnRegistrarCategoria;
        private Button btnConsultarCategoria;
    }
}