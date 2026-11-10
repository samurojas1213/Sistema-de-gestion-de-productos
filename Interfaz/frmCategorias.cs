using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using SistemaGestionProductos.Logica;
using SistemaGestionProductos.Modelos;

namespace Sistema_de_gestion_de_productos.Interfaz
{
    public partial class frmCategorias : Form
    {
        private int idSeleccionado = 0;

        public frmCategorias()
        {
            InitializeComponent();
            Load += frmCategorias_Load;
            dgvCategorias.CellClick += dgvCategorias_CellClick;
        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            CargarCategorias();
        }

        private void CargarCategorias()
        {
            try
            {
                dgvCategorias.DataSource = CategoriaLogica.Listar();
                dgvCategorias.Columns["IdCategoria"].HeaderText = "Id";
                dgvCategorias.Columns["Descripcion"].HeaderText = "Descripción";
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo conectar con la base de datos: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Categoria ObtenerCategoriaDelFormulario()
        {
            errorProvider.Clear();

            string error = CategoriaLogica.ValidarNombre(txtNombre.Text);
            if (error != null)
            {
                errorProvider.SetError(txtNombre, error);
                return null;
            }

            return new Categoria
            {
                IdCategoria = idSeleccionado,
                Nombre = txtNombre.Text,
                Descripcion = txtDescripcion.Text
            };
        }

        private void LimpiarFormulario()
        {
            idSeleccionado = 0;
            txtNombre.Clear();
            txtDescripcion.Clear();
            errorProvider.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var categoria = ObtenerCategoriaDelFormulario();
            if (categoria == null) return;

            try
            {
                CategoriaLogica.Guardar(categoria);
                MessageBox.Show("Categoría registrada correctamente.", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
                CargarCategorias();
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
                MessageBox.Show("Seleccione una categoría de la tabla.", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var categoria = ObtenerCategoriaDelFormulario();
            if (categoria == null) return;

            try
            {
                CategoriaLogica.Modificar(categoria);
                MessageBox.Show("Categoría modificada correctamente.", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
                CargarCategorias();
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
                MessageBox.Show("Seleccione una categoría de la tabla.", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var respuesta = MessageBox.Show("¿Seguro que desea eliminar esta categoría?",
                                            "Confirmar eliminación",
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta != DialogResult.Yes) return;

            try
            {
                CategoriaLogica.Eliminar(idSeleccionado);
                MessageBox.Show("Categoría eliminada correctamente.", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
                CargarCategorias();
            }
            catch (SqlException ex) when (ex.Number == 547)
            {
                MessageBox.Show("No se puede eliminar: la categoría tiene productos asociados.",
                                "Operación no permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var categoria = (Categoria)dgvCategorias.Rows[e.RowIndex].DataBoundItem;
            idSeleccionado = categoria.IdCategoria;
            txtNombre.Text = categoria.Nombre;
            txtDescripcion.Text = categoria.Descripcion;
        }
    }
}