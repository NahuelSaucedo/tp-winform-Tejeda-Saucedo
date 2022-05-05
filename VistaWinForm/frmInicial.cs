using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistaWinForm
{
    public partial class frmInicial : Form
    {
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

        }

    }
}
