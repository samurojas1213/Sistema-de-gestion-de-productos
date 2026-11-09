namespace Sistema_de_gestion_de_productos.Interfaz
{
    partial class frmProductos
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
            txtNombre = new TextBox();
            txtPrecio = new TextBox();
            txtStock = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cboCategoria = new ComboBox();
            label4 = new Label();
            btnGuardar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            txtBuscar = new TextBox();
            label5 = new Label();
            btnBuscar = new Button();
            dgvProductos = new DataGridView();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(88, 89);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(326, 27);
            txtNombre.TabIndex = 0;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(88, 220);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(207, 27);
            txtPrecio.TabIndex = 1;
            txtPrecio.TextChanged += txtPrecio_TextChanged;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(623, 219);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(207, 27);
            txtStock.TabIndex = 2;
            txtStock.TextChanged += txtStock_TextChanged_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(88, 43);
            label1.Name = "label1";
            label1.Size = new Size(110, 31);
            label1.TabIndex = 3;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(88, 170);
            label2.Name = "label2";
            label2.Size = new Size(89, 31);
            label2.TabIndex = 4;
            label2.Text = "Precio:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(623, 170);
            label3.Name = "label3";
            label3.Size = new Size(80, 31);
            label3.TabIndex = 5;
            label3.Text = "Stock:";
            // 
            // cboCategoria
            // 
            cboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Location = new Point(623, 89);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(234, 28);
            cboCategoria.TabIndex = 6;
            cboCategoria.SelectedIndexChanged += cboCategoria_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(623, 43);
            label4.Name = "label4";
            label4.Size = new Size(128, 31);
            label4.TabIndex = 7;
            label4.Text = "Categoria:";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(88, 297);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(151, 51);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(311, 297);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(151, 51);
            btnModificar.TabIndex = 9;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(529, 297);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(151, 51);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(732, 297);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(151, 51);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(88, 514);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(374, 27);
            txtBuscar.TabIndex = 12;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(88, 462);
            label5.Name = "label5";
            label5.Size = new Size(231, 31);
            label5.TabIndex = 13;
            label5.Text = "Buscar por nombre:";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(88, 570);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(151, 51);
            btnBuscar.TabIndex = 14;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(88, 653);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(487, 314);
            dgvProductos.TabIndex = 15;
            dgvProductos.CellContentClick += dataGridView1_CellContentClick;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // frmProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(995, 1011);
            Controls.Add(dgvProductos);
            Controls.Add(btnBuscar);
            Controls.Add(label5);
            Controls.Add(txtBuscar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnGuardar);
            Controls.Add(label4);
            Controls.Add(cboCategoria);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtStock);
            Controls.Add(txtPrecio);
            Controls.Add(txtNombre);
            Name = "frmProductos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmProductos";
            Load += frmProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtPrecio;
        private TextBox txtStock;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cboCategoria;
        private Label label4;
        private Button btnGuardar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private TextBox txtBuscar;
        private Label label5;
        private Button btnBuscar;
        private DataGridView dgvProductos;
        private ErrorProvider errorProvider;
    }
}