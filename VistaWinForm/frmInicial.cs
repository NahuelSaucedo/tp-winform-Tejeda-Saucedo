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
    

    public partial class frmInicial : Form
    {

        private List<Articulos> listaArticulos;
        public frmInicial()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregar agregar = new frmAgregar();
            agregar.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmAgregar modificar = new frmAgregar();
            modificar.ShowDialog();
        }
        private void btnDetalle_Click(object sender, EventArgs e)
        {
            frmDetalle detalle = new frmDetalle();
            detalle.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulos seleccionado;
            try
            {
                DialogResult eliminar = MessageBox.Show("Seguro desea eliminar este elemento?", "Eliminando",MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (eliminar == DialogResult.Yes)
                {
                    seleccionado = (Articulos)dataGridArticulo.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado.id);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void frmInicial_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            listaArticulos = negocio.listar();
            dataGridArticulo.DataSource = listaArticulos;
            dataGridArticulo.Columns["ImagenUrl"].Visible = false;
            pbxArticulo.Load(listaArticulos[0].ImagenUrl);

        }

        private void dataGridArticulo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          Articulos seleccionado = (Articulos) dataGridArticulo.CurrentRow.DataBoundItem;
            pbxArticulo.Load(seleccionado.ImagenUrl);
        }
    }
   

}
