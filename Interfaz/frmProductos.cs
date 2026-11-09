using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SistemaGestionProductos.Logica;
using SistemaGestionProductos.Modelos;

namespace Sistema_de_gestion_de_productos.Interfaz
{
    public partial class frmProductos : Form
    {
        private int idSeleccionado = 0;

        public frmProductos()
        {
            InitializeComponent();
            dgvProductos.CellClick += dgvProductos_CellClick;
        }
            
        private void frmProductos_Load(object sender, EventArgs e)
        {
            CargarCategorias();
            CargarProductos();
        }

        private void CargarCategorias()
        {
            cboCategoria.DataSource = CategoriaLogica.Listar();
            cboCategoria.DisplayMember = "Nombre";
            cboCategoria.ValueMember = "IdCategoria";
            cboCategoria.SelectedIndex = -1;
        }

        private void CargarProductos(string filtro = "")
        {
            try
            {
                var lista = ProductoLogica.Buscar(filtro);
                dgvProductos.DataSource = lista;

                dgvProductos.Columns["IdCategoria"].Visible = false;
                dgvProductos.Columns["IdProducto"].HeaderText = "Id";
                dgvProductos.Columns["FechaRegistro"].HeaderText = "Fecha de registro";
                dgvProductos.Columns["NombreCategoria"].HeaderText = "Categoría";
                dgvProductos.Columns["ValorInventario"].HeaderText = "Valor del inventario";
                dgvProductos.Columns["Precio"].DefaultCellStyle.Format = "N2";
                dgvProductos.Columns["ValorInventario"].DefaultCellStyle.Format = "N2";

                if (filtro != "" && lista.Count == 0)
                {
                    MessageBox.Show("No se encontraron resultados.", "Búsqueda",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo conectar con la base de datos: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Valida los campos y arma el objeto Producto; devuelve null si hay errores
        private Producto ObtenerProductoDelFormulario()
        {
            errorProvider.Clear();
            bool valido = true;

            string error = ProductoLogica.ValidarNombre(txtNombre.Text);
            if (error != null) { errorProvider.SetError(txtNombre, error); valido = false; }

            error = ProductoLogica.ValidarPrecio(txtPrecio.Text, out decimal precio);
            if (error != null) { errorProvider.SetError(txtPrecio, error); valido = false; }

            error = ProductoLogica.ValidarStock(txtStock.Text, out int stock);
            if (error != null) { errorProvider.SetError(txtStock, error); valido = false; }

            error = ProductoLogica.ValidarCategoria(cboCategoria.SelectedValue);
            if (error != null) { errorProvider.SetError(cboCategoria, error); valido = false; }

            if (!valido) return null;

            return new Producto
            {
                IdProducto = idSeleccionado,
                Nombre = txtNombre.Text,
                Precio = precio,
                Stock = stock,
                IdCategoria = (int)cboCategoria.SelectedValue
            };
        }

        private void LimpiarFormulario()
        {
            idSeleccionado = 0;
            txtNombre.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            txtBuscar.Clear();
            cboCategoria.SelectedIndex = -1;
            errorProvider.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var producto = ObtenerProductoDelFormulario();
            if (producto == null) return;

            try
            {
                ProductoLogica.Guardar(producto);
                MessageBox.Show("Producto registrado correctamente.", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
                CargarProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un producto de la tabla.", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var producto = ObtenerProductoDelFormulario();
            if (producto == null) return;

            try
            {
                ProductoLogica.Modificar(producto);
                MessageBox.Show("Producto modificado correctamente.", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
                CargarProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un producto de la tabla.", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var respuesta = MessageBox.Show("¿Seguro que desea eliminar este producto?",
                                            "Confirmar eliminación",
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta != DialogResult.Yes) return;

            try
            {
                ProductoLogica.Eliminar(idSeleccionado);
                MessageBox.Show("Producto eliminado correctamente.", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
                CargarProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarProductos(txtBuscar.Text.Trim());
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            CargarProductos();
        }

        // Al hacer clic en una fila, se cargan sus datos en los campos
        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var producto = (Producto)dgvProductos.Rows[e.RowIndex].DataBoundItem;
            idSeleccionado = producto.IdProducto;
            txtNombre.Text = producto.Nombre;
            txtPrecio.Text = producto.Precio.ToString();
            txtStock.Text = producto.Stock.ToString();
            cboCategoria.SelectedValue = producto.IdCategoria;
        }

        // Métodos vacíos generados por Visual Studio; el diseñador los usa, no los borres
        private void txtStock_TextChanged(object sender, EventArgs e) { }
        private void txtStock_TextChanged_1(object sender, EventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void txtBuscar_TextChanged(object sender, EventArgs e) { }
        private void txtNombre_TextChanged(object sender, EventArgs e) { }
        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e) { }
        private void txtPrecio_TextChanged(object sender, EventArgs e) { }
    }
}