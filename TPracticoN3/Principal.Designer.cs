
namespace TPracticoN3
{
    partial class Principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarUnProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarUnProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vaciarTablaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Categoria = new System.Windows.Forms.TextBox();
            this.txt_Precio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_Categoria = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_iva = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_PrecioFinal = new System.Windows.Forms.TextBox();
            this.Boton_Guardar = new System.Windows.Forms.Button();
            this.vistaProductos = new System.Windows.Forms.DataGridView();
            this.tabla_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabla_categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabla_tipo_iva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabla_precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabla_precioFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelPruebaa = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.BotonLimpiar = new System.Windows.Forms.Button();
            this.botonEliminar = new System.Windows.Forms.Button();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.botonModificar = new System.Windows.Forms.Button();
            this.labelEliminar = new System.Windows.Forms.Label();
            this.label_dobleclick = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vistaProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1329, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actualizarToolStripMenuItem});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(59, 11);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // actualizarToolStripMenuItem
            // 
            this.actualizarToolStripMenuItem.Name = "actualizarToolStripMenuItem";
            this.actualizarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.actualizarToolStripMenuItem.Text = "Actualizar";
            this.actualizarToolStripMenuItem.Click += new System.EventHandler(this.actualizarToolStripMenuItem_Click);
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarUnProductoToolStripMenuItem,
            this.modificarUnProductoToolStripMenuItem,
            this.vaciarTablaToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(85, 11);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // eliminarUnProductoToolStripMenuItem
            // 
            this.eliminarUnProductoToolStripMenuItem.Name = "eliminarUnProductoToolStripMenuItem";
            this.eliminarUnProductoToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.eliminarUnProductoToolStripMenuItem.Text = "Eliminar un producto";
            this.eliminarUnProductoToolStripMenuItem.Click += new System.EventHandler(this.eliminarUnProductoToolStripMenuItem_Click);
            // 
            // modificarUnProductoToolStripMenuItem
            // 
            this.modificarUnProductoToolStripMenuItem.Name = "modificarUnProductoToolStripMenuItem";
            this.modificarUnProductoToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.modificarUnProductoToolStripMenuItem.Text = "Modificar un producto";
            this.modificarUnProductoToolStripMenuItem.Click += new System.EventHandler(this.modificarUnProductoToolStripMenuItem_Click);
            // 
            // vaciarTablaToolStripMenuItem
            // 
            this.vaciarTablaToolStripMenuItem.Name = "vaciarTablaToolStripMenuItem";
            this.vaciarTablaToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.vaciarTablaToolStripMenuItem.Text = "Vaciar tabla";
            this.vaciarTablaToolStripMenuItem.Click += new System.EventHandler(this.vaciarTablaToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bienvenido";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(32, 143);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(136, 22);
            this.txt_Nombre.TabIndex = 2;
            this.txt_Nombre.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_Nombre_MouseClick);
            // 
            // txt_Categoria
            // 
            this.txt_Categoria.Location = new System.Drawing.Point(225, 225);
            this.txt_Categoria.Name = "txt_Categoria";
            this.txt_Categoria.Size = new System.Drawing.Size(116, 22);
            this.txt_Categoria.TabIndex = 3;
            this.txt_Categoria.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_Categoria_MouseClick);
            // 
            // txt_Precio
            // 
            this.txt_Precio.Location = new System.Drawing.Point(32, 330);
            this.txt_Precio.Name = "txt_Precio";
            this.txt_Precio.Size = new System.Drawing.Size(75, 22);
            this.txt_Precio.TabIndex = 5;
            this.txt_Precio.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_Precio_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Precio ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(153, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tipo IVA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Categoria";
            // 
            // cmb_Categoria
            // 
            this.cmb_Categoria.FormattingEnabled = true;
            this.cmb_Categoria.Items.AddRange(new object[] {
            "Alimentos",
            "Bebidas",
            "Higiene personal",
            "Limpieza",
            "Ferreteria",
            "Otros"});
            this.cmb_Categoria.Location = new System.Drawing.Point(224, 141);
            this.cmb_Categoria.Name = "cmb_Categoria";
            this.cmb_Categoria.Size = new System.Drawing.Size(139, 24);
            this.cmb_Categoria.TabIndex = 10;
            this.cmb_Categoria.SelectionChangeCommitted += new System.EventHandler(this.cmb_Categoria_SelectionChangeCommitted);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(222, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Seleccione Categoria";
            // 
            // cmb_iva
            // 
            this.cmb_iva.FormattingEnabled = true;
            this.cmb_iva.Items.AddRange(new object[] {
            "21%",
            "10.5%",
            "27%",
            "4%"});
            this.cmb_iva.Location = new System.Drawing.Point(156, 330);
            this.cmb_iva.Name = "cmb_iva";
            this.cmb_iva.Size = new System.Drawing.Size(82, 24);
            this.cmb_iva.TabIndex = 12;
            this.cmb_iva.SelectionChangeCommitted += new System.EventHandler(this.cmb_iva_SelectionChangeCommitted);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(286, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Precio final";
            // 
            // txt_PrecioFinal
            // 
            this.txt_PrecioFinal.Location = new System.Drawing.Point(289, 330);
            this.txt_PrecioFinal.Name = "txt_PrecioFinal";
            this.txt_PrecioFinal.ReadOnly = true;
            this.txt_PrecioFinal.Size = new System.Drawing.Size(100, 22);
            this.txt_PrecioFinal.TabIndex = 14;
            // 
            // Boton_Guardar
            // 
            this.Boton_Guardar.Location = new System.Drawing.Point(133, 394);
            this.Boton_Guardar.Name = "Boton_Guardar";
            this.Boton_Guardar.Size = new System.Drawing.Size(168, 65);
            this.Boton_Guardar.TabIndex = 15;
            this.Boton_Guardar.Text = "Guardar";
            this.Boton_Guardar.UseVisualStyleBackColor = true;
            this.Boton_Guardar.Click += new System.EventHandler(this.Boton_Guardar_Click);
            // 
            // vistaProductos
            // 
            this.vistaProductos.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.vistaProductos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.vistaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vistaProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tabla_nombre,
            this.tabla_categoria,
            this.tabla_tipo_iva,
            this.tabla_precio,
            this.tabla_precioFinal});
            this.vistaProductos.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.vistaProductos.Location = new System.Drawing.Point(525, 98);
            this.vistaProductos.Name = "vistaProductos";
            this.vistaProductos.ReadOnly = true;
            this.vistaProductos.RowHeadersWidth = 51;
            this.vistaProductos.RowTemplate.Height = 24;
            this.vistaProductos.Size = new System.Drawing.Size(792, 447);
            this.vistaProductos.TabIndex = 16;
            this.vistaProductos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vistaProductos_CellDoubleClick);
            // 
            // tabla_nombre
            // 
            this.tabla_nombre.HeaderText = "Nombre";
            this.tabla_nombre.MinimumWidth = 6;
            this.tabla_nombre.Name = "tabla_nombre";
            this.tabla_nombre.ReadOnly = true;
            this.tabla_nombre.Width = 125;
            // 
            // tabla_categoria
            // 
            this.tabla_categoria.HeaderText = "Categoria";
            this.tabla_categoria.MinimumWidth = 6;
            this.tabla_categoria.Name = "tabla_categoria";
            this.tabla_categoria.ReadOnly = true;
            this.tabla_categoria.Width = 125;
            // 
            // tabla_tipo_iva
            // 
            this.tabla_tipo_iva.HeaderText = "Tipo IVA";
            this.tabla_tipo_iva.MinimumWidth = 6;
            this.tabla_tipo_iva.Name = "tabla_tipo_iva";
            this.tabla_tipo_iva.ReadOnly = true;
            this.tabla_tipo_iva.Width = 70;
            // 
            // tabla_precio
            // 
            this.tabla_precio.HeaderText = "Precio bruto";
            this.tabla_precio.MinimumWidth = 6;
            this.tabla_precio.Name = "tabla_precio";
            this.tabla_precio.ReadOnly = true;
            this.tabla_precio.Width = 110;
            // 
            // tabla_precioFinal
            // 
            this.tabla_precioFinal.HeaderText = "Precio Final";
            this.tabla_precioFinal.MinimumWidth = 6;
            this.tabla_precioFinal.Name = "tabla_precioFinal";
            this.tabla_precioFinal.ReadOnly = true;
            this.tabla_precioFinal.Width = 110;
            // 
            // labelPruebaa
            // 
            this.labelPruebaa.AutoSize = true;
            this.labelPruebaa.CausesValidation = false;
            this.labelPruebaa.Font = new System.Drawing.Font("Verdana", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPruebaa.Location = new System.Drawing.Point(739, 66);
            this.labelPruebaa.Name = "labelPruebaa";
            this.labelPruebaa.Size = new System.Drawing.Size(331, 29);
            this.labelPruebaa.TabIndex = 17;
            this.labelPruebaa.Text = "Productos almacenados";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 333);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "$";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(267, 333);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "$";
            // 
            // BotonLimpiar
            // 
            this.BotonLimpiar.Location = new System.Drawing.Point(377, 436);
            this.BotonLimpiar.Name = "BotonLimpiar";
            this.BotonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.BotonLimpiar.TabIndex = 20;
            this.BotonLimpiar.Text = "Limpiar";
            this.BotonLimpiar.UseVisualStyleBackColor = true;
            this.BotonLimpiar.Click += new System.EventHandler(this.BotonLimpiar_Click);
            // 
            // botonEliminar
            // 
            this.botonEliminar.Location = new System.Drawing.Point(567, 551);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.Size = new System.Drawing.Size(85, 35);
            this.botonEliminar.TabIndex = 21;
            this.botonEliminar.Text = "Eliminar";
            this.botonEliminar.UseVisualStyleBackColor = true;
            this.botonEliminar.Visible = false;
            this.botonEliminar.Click += new System.EventHandler(this.botonEliminar_Click);
            // 
            // botonCancelar
            // 
            this.botonCancelar.Location = new System.Drawing.Point(849, 551);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(85, 35);
            this.botonCancelar.TabIndex = 22;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            this.botonCancelar.Visible = false;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // botonModificar
            // 
            this.botonModificar.Location = new System.Drawing.Point(690, 551);
            this.botonModificar.Name = "botonModificar";
            this.botonModificar.Size = new System.Drawing.Size(85, 35);
            this.botonModificar.TabIndex = 23;
            this.botonModificar.Text = "Modificar";
            this.botonModificar.UseVisualStyleBackColor = true;
            this.botonModificar.Visible = false;
            this.botonModificar.Click += new System.EventHandler(this.botonModificar_Click);
            // 
            // labelEliminar
            // 
            this.labelEliminar.AutoSize = true;
            this.labelEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEliminar.Location = new System.Drawing.Point(32, 177);
            this.labelEliminar.Name = "labelEliminar";
            this.labelEliminar.Size = new System.Drawing.Size(0, 18);
            this.labelEliminar.TabIndex = 24;
            this.labelEliminar.Visible = false;
            // 
            // label_dobleclick
            // 
            this.label_dobleclick.AutoSize = true;
            this.label_dobleclick.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dobleclick.Location = new System.Drawing.Point(28, 525);
            this.label_dobleclick.Name = "label_dobleclick";
            this.label_dobleclick.Size = new System.Drawing.Size(0, 20);
            this.label_dobleclick.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 505);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(450, 69);
            this.label10.TabIndex = 26;
            this.label10.Visible = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1329, 638);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label_dobleclick);
            this.Controls.Add(this.labelEliminar);
            this.Controls.Add(this.botonModificar);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.botonEliminar);
            this.Controls.Add(this.BotonLimpiar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelPruebaa);
            this.Controls.Add(this.vistaProductos);
            this.Controls.Add(this.Boton_Guardar);
            this.Controls.Add(this.txt_PrecioFinal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmb_iva);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmb_Categoria);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Precio);
            this.Controls.Add(this.txt_Categoria);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestionar";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vistaProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_Categoria;
        private System.Windows.Forms.TextBox txt_Precio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_Categoria;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_iva;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_PrecioFinal;
        private System.Windows.Forms.Button Boton_Guardar;
        private System.Windows.Forms.DataGridView vistaProductos;
        private System.Windows.Forms.Label labelPruebaa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BotonLimpiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn tabla_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn tabla_categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn tabla_tipo_iva;
        private System.Windows.Forms.DataGridViewTextBoxColumn tabla_precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn tabla_precioFinal;
        private System.Windows.Forms.ToolStripMenuItem actualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarUnProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarUnProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vaciarTablaToolStripMenuItem;
        private System.Windows.Forms.Button botonEliminar;
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.Button botonModificar;
        private System.Windows.Forms.Label labelEliminar;
        private System.Windows.Forms.Label label_dobleclick;
        private System.Windows.Forms.Label label10;
    }
}

