﻿using System;
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
            pbxArticulo.Load(listaArticulos[0].ImagenUrl);
          
            cbcampo.Items.Add("Codigo");
            cbcampo.Items.Add("Nombre");
            cbcampo.Items.Add("Precio");

        }

        private void dataGridArticulo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridArticulo.CurrentRow != null) { 
          Articulos seleccionado = (Articulos) dataGridArticulo.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.ImagenUrl);
            }


        }

        private void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                listaArticulos = negocio.listar();
                dataGridArticulo.DataSource = listaArticulos;
                ocultarColumnas();
                cargarImagen(listaArticulos[0].ImagenUrl);
            
                
            }
            catch (Exception ex)
            {

                throw ex;
            }
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
            }
        }



         private void tbxBusqueda_TextChanged(object sender, EventArgs e)
        {
            List<Articulos> filtro;
            string Reset = tbxBusqueda.Text;

            if (Reset != "")
            {
                filtro = listaArticulos.FindAll(x => x.Nombre.ToUpper().Contains(tbxBusqueda.Text.ToUpper()) ||  x.Codigo.ToUpper().Contains(tbxBusqueda.Text.ToUpper()) || x.Marca.Descripcion.ToUpper().Contains(tbxBusqueda.Text.ToUpper()) || x.Categoria.Descripcion.ToUpper().Contains(tbxBusqueda.Text.ToUpper()));
            }
            else
            {
                filtro = listaArticulos;
            }


            dataGridArticulo.DataSource = null;
            dataGridArticulo.DataSource = filtro;
            ocultarColumnas();

        }

        private void ocultarColumnas()
        {
            dataGridArticulo.Columns["ImagenUrl"].Visible = false;
        }

        private void btnAvanzado_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
           
            try
            {
            string campo = cbcampo.SelectedItem.ToString();
            string criterio = cbcriterio.SelectedItem.ToString();
            string filtro = txtfiltro.Text;
                dataGridArticulo.DataSource = negocio.filtrar(campo, criterio, filtro);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cbcampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opc = cbcampo.SelectedItem.ToString();
            if(opc == "Numero")
            {
                cbcriterio.Items.Clear();
                cbcriterio.Items.Add("Menor a");
                cbcriterio.Items.Add("Mayor a");
                cbcriterio.Items.Add("Igual a");
            }

            else
            {
                cbcriterio.Items.Clear();
                cbcriterio.Items.Add("Comienza con");
                cbcriterio.Items.Add("Termina con");
                cbcriterio.Items.Add("Igual a");
            }
           

        }
    }
   

}
