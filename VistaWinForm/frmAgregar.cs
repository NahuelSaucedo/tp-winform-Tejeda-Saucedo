using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;
using Modelo;

namespace VistaWinForm
{
    public partial class frmAgregar : Form
    {
        Articulos articulo = null;
        public frmAgregar()
        {
            InitializeComponent();
        }
        void cargarImagen(string imagen)
        {
            try
            {
                pbxArticulo.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxArticulo.Load("https://previews.123rf.com/images/freshwater/freshwater1711/freshwater171100021/89104479-p%C3%ADxel-404-p%C3%A1gina-de-error-p%C3%A1gina-no-encontrada.jpg");
                MessageBox.Show(ex.Message);
            }
        }
        public frmAgregar(Articulos articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Articulo";
        }
        private void frmAgregar_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            try
            {

                comboBoxMarca.DataSource = marcaNegocio.listar();
                comboBoxCategoria.DataSource = categoriaNegocio.listar();
                comboBoxMarca.ValueMember = "id";
                comboBoxMarca.DisplayMember = "descripcion";
                comboBoxCategoria.ValueMember = "id";
                comboBoxCategoria.DisplayMember = "descripcion";
                if (articulo != null)
                {
                    textBoxCodArt.Text = articulo.Codigo;
                    textBoxNombre.Text = articulo.Nombre;
                    textBoxDescripcion.Text = articulo.Descripcion;
                    textBoxUrl.Text = articulo.ImagenUrl;
                    comboBoxMarca.SelectedValue = articulo.Marca.Descripcion;
                    comboBoxCategoria.SelectedValue = articulo.Categoria.Descripcion;
                    textBoxPrecio.Text = Convert.ToString(articulo.Precio);
                    cargarImagen(articulo.ImagenUrl);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio artNegocio = new ArticuloNegocio();
            try
            {
                if (articulo == null)
                    articulo = new Articulos();
                articulo.Codigo = textBoxCodArt.Text;
                articulo.Nombre = textBoxNombre.Text;
                articulo.Descripcion = textBoxDescripcion.Text;
                articulo.Marca = (Marcas)comboBoxMarca.SelectedItem;
                articulo.Categoria = (Categorias)comboBoxCategoria.SelectedItem;
                articulo.Precio = decimal.Parse(textBoxPrecio.Text);
                articulo.ImagenUrl = textBoxUrl.Text;
                articulo.Categoria.ID = Convert.ToInt32(comboBoxCategoria.SelectedValue);
                articulo.Marca.ID = Convert.ToInt32(comboBoxCategoria.SelectedValue);

                if (articulo.id == 0)
                {
                    artNegocio.agregar(articulo);
                    MessageBox.Show("Se agrego correctamente");


                }
                else
                {
                    artNegocio.modificar(articulo);
                    MessageBox.Show("Se modifico correctamente");
                }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

    }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("Esta accion va a deshacer todos los cambios realizados", "Seguro queres salir?", MessageBoxButtons.OKCancel))
            {
                frmAgregar.ActiveForm.Close();
            }
        }

        private void pbxArticulo_MouseCaptureChanged(object sender, EventArgs e)
        {
            cargarImagen(textBoxUrl.Text);
        }
    }
}
