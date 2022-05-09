using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using Controlador;


namespace VistaWinForm
{
    public partial class frmDetalle : Form
    {
        Articulos articulo = new Articulos();
        public frmDetalle(Articulos articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }

        private void frmDetalle_Load(object sender, EventArgs e)
        {
            cargarImagen(articulo.ImagenUrl);
            tbxCodArt.Text = articulo.Codigo;
            tbxNombreArt.Text = articulo.Nombre;
            string precio = "$" + articulo.Precio.ToString();
            tbxPrecio.Text = precio;
            tbxDescripcion.Text = articulo.Descripcion;

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
    }
}
