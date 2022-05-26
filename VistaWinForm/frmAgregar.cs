using Controlador;
using Modelo;
using System;
using System.Windows.Forms;

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
                comboBoxMarca.ValueMember = "Id";
                comboBoxMarca.DisplayMember = "descripcion";
                comboBoxCategoria.ValueMember = "Id";
                comboBoxCategoria.DisplayMember = "descripcion";
                if (articulo != null)
                {
                    textBoxCodArt.Text = articulo.Codigo;
                    textBoxNombre.Text = articulo.Nombre;
                    textBoxDescripcion.Text = articulo.Descripcion;
                    textBoxUrl.Text = articulo.ImagenUrl;
                    comboBoxMarca.SelectedIndex = articulo.Marca.ID;
                    comboBoxCategoria.SelectedIndex = articulo.Categoria.ID;
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
            if(checkNullity())
            try
            {
                if (articulo == null)
                {
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

        private void textBoxPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59 || e.KeyChar == 46) && e.KeyChar != 8 && e.KeyChar != 44)
                e.Handled = true;
        }
        private bool checkNullity()
        {
            if (string.IsNullOrEmpty(textBoxCodArt.Text) || string.IsNullOrEmpty(textBoxNombre.Text) || string.IsNullOrEmpty(comboBoxCategoria.Text) || string.IsNullOrEmpty(comboBoxMarca.Text))
            {
                MessageBox.Show("Por favor, completar los campos obligatorios","Completar campos");
                return false;
            }
            return true;
        }

        private void textBoxCodArt_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCodArt.Text))
            {
                textBoxCodArt.BackColor = System.Drawing.Color.IndianRed;
            }
            else
            {
                textBoxCodArt.BackColor = System.Drawing.Color.FromArgb(229, 239, 193);
            }
        }

        private void textBoxNombre_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNombre.Text))
            {
                textBoxNombre.BackColor = System.Drawing.Color.IndianRed;
            }
            else
            {
                textBoxNombre.BackColor = System.Drawing.Color.FromArgb(229, 239, 193);
            }
        }

        private void comboBoxMarca_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxMarca.Text))
            {
                comboBoxMarca.BackColor = System.Drawing.Color.IndianRed;
            }
            else
            {
                comboBoxMarca.BackColor = System.Drawing.Color.FromArgb(229, 239, 193);
            }
        }

        private void comboBoxCategoria_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxCategoria.Text))
            {
                comboBoxCategoria.BackColor = System.Drawing.Color.IndianRed;
            }
            else
            {
                comboBoxCategoria.BackColor = System.Drawing.Color.FromArgb(229, 239, 193);
            }
        }
    }
}
