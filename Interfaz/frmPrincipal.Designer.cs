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
            btnAdministraciondeCategorias = new Button();
            btnAdministraciondeProductos = new Button();
            btnAsignaciondeCategorias = new Button();
            button2 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnAdministraciondeCategorias
            // 
            btnAdministraciondeCategorias.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdministraciondeCategorias.Location = new Point(181, 134);
            btnAdministraciondeCategorias.Name = "btnAdministraciondeCategorias";
            btnAdministraciondeCategorias.Size = new Size(423, 67);
            btnAdministraciondeCategorias.TabIndex = 3;
            btnAdministraciondeCategorias.Text = "Administracion de categorias";
            btnAdministraciondeCategorias.UseVisualStyleBackColor = true;
            // 
            // btnAdministraciondeProductos
            // 
            btnAdministraciondeProductos.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdministraciondeProductos.Location = new Point(1076, 134);
            btnAdministraciondeProductos.Name = "btnAdministraciondeProductos";
            btnAdministraciondeProductos.Size = new Size(423, 67);
            btnAdministraciondeProductos.TabIndex = 4;
            btnAdministraciondeProductos.Text = "Administracion de productos";
            btnAdministraciondeProductos.UseVisualStyleBackColor = true;
            // 
            // btnAsignaciondeCategorias
            // 
            btnAsignaciondeCategorias.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAsignaciondeCategorias.Location = new Point(181, 385);
            btnAsignaciondeCategorias.Name = "btnAsignaciondeCategorias";
            btnAsignaciondeCategorias.Size = new Size(423, 67);
            btnAsignaciondeCategorias.TabIndex = 5;
            btnAsignaciondeCategorias.Text = "Asignacion de categorias";
            btnAsignaciondeCategorias.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(1076, 385);
            button2.Name = "button2";
            button2.Size = new Size(423, 67);
            button2.TabIndex = 6;
            button2.Text = "Administracion de categorias";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(590, 29);
            label1.Name = "label1";
            label1.Size = new Size(497, 34);
            label1.TabIndex = 7;
            label1.Text = "Sistema de gestion de productos";
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1820, 910);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(btnAsignaciondeCategorias);
            Controls.Add(btnAdministraciondeProductos);
            Controls.Add(btnAdministraciondeCategorias);
            Name = "frmPrincipal";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAdministraciondeCategorias;
        private Button btnAdministraciondeProductos;
        private Button btnAsignaciondeCategorias;
        private Button button2;
        private Label label1;
    }
}
