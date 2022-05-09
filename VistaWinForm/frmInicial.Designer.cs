
namespace VistaWinForm
{
    partial class frmInicial
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridArticulo = new System.Windows.Forms.DataGridView();
            this.tbxBusqueda = new System.Windows.Forms.TextBox();
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnDetalle = new System.Windows.Forms.Button();
            this.btnAvanzado = new System.Windows.Forms.Button();
            this.lblcampo = new System.Windows.Forms.Label();
            this.cbcampo = new System.Windows.Forms.ComboBox();
            this.lblcriterio = new System.Windows.Forms.Label();
            this.cbcriterio = new System.Windows.Forms.ComboBox();
            this.lvlfiltroAvanzado = new System.Windows.Forms.Label();
            this.txtfiltro = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridArticulo
            // 
            this.dataGridArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridArticulo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(123)))), ((int)(((byte)(131)))));
            this.dataGridArticulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridArticulo.Location = new System.Drawing.Point(4, 132);
            this.dataGridArticulo.Name = "dataGridArticulo";
            this.dataGridArticulo.Size = new System.Drawing.Size(595, 348);
            this.dataGridArticulo.TabIndex = 0;
            this.dataGridArticulo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridArticulo_CellContentClick);
            // 
            // tbxBusqueda
            // 
            this.tbxBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(193)))));
            this.tbxBusqueda.Location = new System.Drawing.Point(15, 12);
            this.tbxBusqueda.Name = "tbxBusqueda";
            this.tbxBusqueda.Size = new System.Drawing.Size(592, 20);
            this.tbxBusqueda.TabIndex = 1;
            this.tbxBusqueda.TextChanged += new System.EventHandler(this.tbxBusqueda_TextChanged);
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxArticulo.Location = new System.Drawing.Point(612, 225);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(160, 160);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticulo.TabIndex = 2;
            this.pbxArticulo.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.Location = new System.Drawing.Point(4, 498);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.Location = new System.Drawing.Point(107, 498);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.Location = new System.Drawing.Point(289, 498);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnDetalle
            // 
            this.btnDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetalle.Location = new System.Drawing.Point(197, 498);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(75, 23);
            this.btnDetalle.TabIndex = 6;
            this.btnDetalle.Text = "Detalle";
            this.btnDetalle.UseVisualStyleBackColor = true;
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // btnAvanzado
            // 
            this.btnAvanzado.Location = new System.Drawing.Point(639, 38);
            this.btnAvanzado.Name = "btnAvanzado";
            this.btnAvanzado.Size = new System.Drawing.Size(75, 23);
            this.btnAvanzado.TabIndex = 7;
            this.btnAvanzado.Text = "Avanzado";
            this.btnAvanzado.UseVisualStyleBackColor = true;
            this.btnAvanzado.Click += new System.EventHandler(this.btnAvanzado_Click);
            // 
            // lblcampo
            // 
            this.lblcampo.AutoSize = true;
            this.lblcampo.Location = new System.Drawing.Point(1, 41);
            this.lblcampo.Name = "lblcampo";
            this.lblcampo.Size = new System.Drawing.Size(40, 13);
            this.lblcampo.TabIndex = 8;
            this.lblcampo.Text = "Campo";
            // 
            // cbcampo
            // 
            this.cbcampo.AllowDrop = true;
            this.cbcampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcampo.FormattingEnabled = true;
            this.cbcampo.Location = new System.Drawing.Point(47, 38);
            this.cbcampo.Name = "cbcampo";
            this.cbcampo.Size = new System.Drawing.Size(121, 21);
            this.cbcampo.TabIndex = 9;
            this.cbcampo.SelectedIndexChanged += new System.EventHandler(this.cbcampo_SelectedIndexChanged);
            // 
            // lblcriterio
            // 
            this.lblcriterio.AutoSize = true;
            this.lblcriterio.Location = new System.Drawing.Point(222, 41);
            this.lblcriterio.Name = "lblcriterio";
            this.lblcriterio.Size = new System.Drawing.Size(39, 13);
            this.lblcriterio.TabIndex = 10;
            this.lblcriterio.Text = "Criterio";
            // 
            // cbcriterio
            // 
            this.cbcriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcriterio.FormattingEnabled = true;
            this.cbcriterio.Location = new System.Drawing.Point(289, 38);
            this.cbcriterio.Name = "cbcriterio";
            this.cbcriterio.Size = new System.Drawing.Size(121, 21);
            this.cbcriterio.TabIndex = 11;
            // 
            // lvlfiltroAvanzado
            // 
            this.lvlfiltroAvanzado.AutoSize = true;
            this.lvlfiltroAvanzado.Location = new System.Drawing.Point(455, 41);
            this.lvlfiltroAvanzado.Name = "lvlfiltroAvanzado";
            this.lvlfiltroAvanzado.Size = new System.Drawing.Size(29, 13);
            this.lvlfiltroAvanzado.TabIndex = 12;
            this.lvlfiltroAvanzado.Text = "Filtro";
            this.lvlfiltroAvanzado.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtfiltro
            // 
            this.txtfiltro.Location = new System.Drawing.Point(499, 41);
            this.txtfiltro.Name = "txtfiltro";
            this.txtfiltro.Size = new System.Drawing.Size(100, 20);
            this.txtfiltro.TabIndex = 13;
            // 
            // frmInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(123)))), ((int)(((byte)(131)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.txtfiltro);
            this.Controls.Add(this.lvlfiltroAvanzado);
            this.Controls.Add(this.cbcriterio);
            this.Controls.Add(this.lblcriterio);
            this.Controls.Add(this.cbcampo);
            this.Controls.Add(this.lblcampo);
            this.Controls.Add(this.btnAvanzado);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pbxArticulo);
            this.Controls.Add(this.tbxBusqueda);
            this.Controls.Add(this.dataGridArticulo);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "frmInicial";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de articulos";
            this.Load += new System.EventHandler(this.frmInicial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridArticulo;
        private System.Windows.Forms.TextBox tbxBusqueda;
        private System.Windows.Forms.PictureBox pbxArticulo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnDetalle;
        private System.Windows.Forms.Button btnAvanzado;
        private System.Windows.Forms.Label lblcampo;
        private System.Windows.Forms.ComboBox cbcampo;
        private System.Windows.Forms.Label lblcriterio;
        private System.Windows.Forms.ComboBox cbcriterio;
        private System.Windows.Forms.Label lvlfiltroAvanzado;
        private System.Windows.Forms.TextBox txtfiltro;
    }
}

