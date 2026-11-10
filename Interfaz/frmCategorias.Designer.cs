namespace Sistema_de_gestion_de_productos.Interfaz
{
    partial class frmCategorias
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            btnGuardar = new Button();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            errorProvider = new ErrorProvider(components);
            txtNombre = new TextBox();
            txtDescripcion = new TextBox();
            dgvCategorias = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(98, 38);
            label1.Name = "label1";
            label1.Size = new Size(110, 31);
            label1.TabIndex = 5;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(98, 129);
            label2.Name = "label2";
            label2.Size = new Size(151, 31);
            label2.TabIndex = 7;
            label2.Text = "Descripcion:";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(98, 266);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(151, 51);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(698, 266);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(151, 51);
            btnLimpiar.TabIndex = 14;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(497, 266);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(151, 51);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(293, 266);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(151, 51);
            btnModificar.TabIndex = 12;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(98, 72);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(346, 27);
            txtNombre.TabIndex = 15;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(98, 163);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(346, 27);
            txtDescripcion.TabIndex = 16;
            // 
            // dgvCategorias
            // 
            dgvCategorias.AllowUserToAddRows = false;
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Location = new Point(98, 361);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.ReadOnly = true;
            dgvCategorias.RowHeadersWidth = 51;
            dgvCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategorias.Size = new Size(550, 293);
            dgvCategorias.TabIndex = 17;
            // 
            // frmCategorias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(982, 692);
            Controls.Add(dgvCategorias);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombre);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnGuardar);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmCategorias";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCategorias";
            Load += frmCategorias_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnGuardar;
        private Button btnLimpiar;
        private Button btnEliminar;
        private Button btnModificar;
        private ErrorProvider errorProvider;
        private DataGridView dgvCategorias;
        private TextBox txtDescripcion;
        private TextBox txtNombre;
    }
}