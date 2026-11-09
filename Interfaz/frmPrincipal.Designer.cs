namespace Sistema_de_gestion_de_productos
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnCategorias = new Button();
            btnProductos = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(125, 26);
            label1.Name = "label1";
            label1.Size = new Size(497, 34);
            label1.TabIndex = 7;
            label1.Text = "Sistema de gestion de productos";
            // 
            // btnCategorias
            // 
            btnCategorias.BackColor = SystemColors.ScrollBar;
            btnCategorias.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCategorias.Location = new Point(125, 103);
            btnCategorias.Name = "btnCategorias";
            btnCategorias.Size = new Size(497, 82);
            btnCategorias.TabIndex = 8;
            btnCategorias.Text = "Administrar categorías";
            btnCategorias.UseVisualStyleBackColor = false;
            btnCategorias.Click += btnCategorias_Click_1;
            // 
            // btnProductos
            // 
            btnProductos.BackColor = SystemColors.ScrollBar;
            btnProductos.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProductos.Location = new Point(125, 209);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(497, 82);
            btnProductos.TabIndex = 9;
            btnProductos.Text = "Administrar productos";
            btnProductos.UseVisualStyleBackColor = false;
            btnProductos.Click += btnProductos_Click_1;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(767, 403);
            Controls.Add(btnProductos);
            Controls.Add(btnCategorias);
            Controls.Add(label1);
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += frmPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button btnCategorias;
        private Button btnProductos;
    }
}
