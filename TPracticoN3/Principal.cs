using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPracticoN3
{
    public partial class Principal : Form
    {
        double precioIngresado, precioFinal, iva = 1.0, precioEliminar, Mod_PSinIva;
        string mensaje;
        int espacios = 5, llenos = 0;
        string prodELim;
        bool bandera = false;


        //arreglos de memoria
        string[] nombreProducto;
        string[] categoriaProducto;
        string[] tipoIva;
        double[] precioSinIva;
        double[] precioConIva;
        
        

        public Principal()
        {
            InitializeComponent();


            cmb_iva.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Categoria.DropDownStyle = ComboBoxStyle.DropDownList;
            vistaProductos.AllowUserToAddRows = false;

            progBar_memoria.Maximum = espacios;


            nombreProducto = new string [espacios];
            categoriaProducto = new string[espacios];
            tipoIva = new string[espacios];
            precioSinIva = new double[espacios];
            precioConIva = new double[espacios];

         

        }


        public bool CalcularIva()
        {

            string selectItem;
            
            mensaje = "!Valor no permitido¡";
            iva = 1.0;
            try
            {
                
                if (txt_Precio.Text.Contains(","))
                {
                    txt_Precio.Text = txt_Precio.Text.Replace(",",".");
                }
                precioIngresado = double.Parse(txt_Precio.Text.Trim(), CultureInfo.InvariantCulture);




                selectItem = cmb_iva.SelectedItem.ToString().Trim();
                switch (selectItem)
                {

                    case "21%":
                        iva = iva + 0.21;
                        break;
                    case "10.5%":
                        iva = iva + 0.105;
                        break;
                    case "27%":
                        iva = iva + 0.27;
                        break;
                    case "4%":
                        iva = iva + 0.04;
                        break;
                    default:
                        iva = iva + 0.21;
                        Console.WriteLine("entró en default");
                        break;
                }

                precioFinal = precioIngresado * iva;
                txt_PrecioFinal.Text = precioFinal.ToString();
                txt_PrecioFinal.BackColor = Color.LightGreen;
                txt_Precio.BackColor = Color.LightGreen;
                return true;
            }
            catch (Exception e)
            {
                if (txt_Precio.Text.Trim()=="")
                {
                    mensaje = "El campo está vacío";
                }
                txt_Precio.BackColor = Color.OrangeRed;
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Console.WriteLine(e.Message+"aca que esta pasando");
                return false;
            }

            
        }

        private void Boton_Guardar_Click(object sender, EventArgs e)
        {
            bool validar_ok, iva_ok;

            
            validar_ok = ValidarCampos();

            
            if (validar_ok)
            {
                if (cmb_iva.SelectedIndex == -1)
                {
                    cmb_iva.SelectedIndex = 0;   

                }
                iva_ok = CalcularIva();

                if (iva_ok)
                {
                    
                    guardar();
                    
                }
            }
 

        }

        public void guardar()
        {

            try
            {
                if (llenos<(espacios))
                {
                    for (int i = 0; i < espacios; i++)
                    {

                        if (nombreProducto[i] == null && nombreProducto[i] == null)
                        {

                            nombreProducto[i] = txt_Nombre.Text.Trim().ToLower();
                            categoriaProducto[i] = txt_Categoria.Text.Trim().ToLower();
                            tipoIva[i] = cmb_iva.SelectedItem.ToString().Trim();
                            precioSinIva[i] = precioIngresado;
                            precioConIva[i] = double.Parse(txt_PrecioFinal.Text.Trim());
                            llenos += 1;
                            i = espacios;
                            mostrarDatos();
                            memoriaDisponible();
                            Limpiar();
                        }
                    }
                }
                else
                {
                    mensaje = "Deberá eliminar algun producto para seguir guardando";
                    MessageBox.Show(mensaje, "Memoria Llena", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e + " Error en la carga al arreglo");
                
            }

        }

        public void Limpiar()
        {
            txt_Nombre.Text = "";
            txt_Categoria.Text = "";
            txt_Precio.Text = "";
            txt_PrecioFinal.Text = "";

            cmb_iva.SelectedIndex = -1;
            cmb_Categoria.SelectedIndex = -1;

            txt_Nombre.BackColor = Color.White;
            txt_Categoria.BackColor = Color.White;
            txt_Precio.BackColor = Color.White;
            txt_PrecioFinal.BackColor = Color.White;
        }

        public void mostrarDatos()
        {
            try
            {
                vistaProductos.Rows.Clear();

                for (int i = 0; i < espacios; i++)
                {
                    if (nombreProducto[i] != null && categoriaProducto[i] !=null)
                    {
                        DataGridViewRow fila = new DataGridViewRow();
                        fila.CreateCells(vistaProductos);
                        fila.Cells[0].Value = nombreProducto[i];
                        fila.Cells[1].Value = categoriaProducto[i];
                        fila.Cells[2].Value = tipoIva[i];
                        fila.Cells[3].Value = precioSinIva[i];
                        fila.Cells[4].Value = precioConIva[i];

                        
                        vistaProductos.Rows.Add(fila);
                        //memoriaDisponible();
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e + "Error en la carga a la tabla");
                
            }
        }
        private void BotonLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }


        private void cmb_iva_SelectionChangeCommitted(object sender, EventArgs e)
        {
             CalcularIva().ToString();
        }

        private void txt_Categoria_MouseClick(object sender, MouseEventArgs e)
        {
            if (txt_Categoria.BackColor == Color.OrangeRed)
            {
                txt_Categoria.BackColor = Color.White;
            }

        }

        private void eliminarUnProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (llenos == 0)
            {
                mensaje = "No hay registros guardados.";
                MessageBox.Show(mensaje, "Memoria vacía", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    bandera = true;
                    bloquearEntradas(1);
                }
                catch (Exception)
                {

                }
            }
            
            

        }

        public void desbloquearEntradas(int arg)
        {

            //labelEliminar.Visible = false;
            label_subtitulo.Text = "Cargar nuevo producto";
            txt_Categoria.ReadOnly =false;
            txt_Precio.ReadOnly = false;
            txt_Nombre.ReadOnly = false;


            cmb_Categoria.SelectedIndex = -1;
            
            cmb_Categoria.Enabled = true;

            Boton_Guardar.Enabled = true;
            BotonLimpiar.Enabled = true;
            botonEliminar.Visible = false;
            

            switch (arg)
            {
                case 0:     // habilita todos los componentes para cargar normalmente
                    bandera = false;
                    Limpiar();
                    botonCancelar.Visible = false;
                    botonModificar.Visible = false;
                    cmb_iva.Enabled = true;
                    label10.Visible = false;
                    cmb_iva.SelectedIndex = -1;

                    break;
                case 1:           // 1 habilita para modificar pero no el bton guardar p evitar otro regist nuevo no vacia
                    bandera = true;
                    Boton_Guardar.Enabled = false;

                    break;
                default:
                    
                    break;
            }

        }
        public void bloquearEntradas(int opciones)
        {
            Limpiar();
            txt_Nombre.BackColor = Color.LightGreen;
            txt_Precio.BackColor = Color.LightGreen;
            txt_PrecioFinal.BackColor = Color.LightGreen;
            txt_Categoria.ReadOnly = true;
            txt_Precio.ReadOnly = true;
            txt_Nombre.ReadOnly = true;
            cmb_iva.SelectedIndex = -1;
            cmb_Categoria.SelectedIndex = -1;

            Boton_Guardar.Enabled = false;
            botonCancelar.Visible = true;

            label10.Text = "Realice doble click sobre el producto\n que desea modificar/eliminar";
            label10.Visible = true;
            switch (opciones)
            {
                case 1:             // para eliminar
                    label_subtitulo.Text = "Producto a eliminar";
                    //labelEliminar.Visible = true;
                    cmb_iva.Enabled = false;
                    cmb_Categoria.Enabled = false;
                    BotonLimpiar.Enabled = false;
                    botonModificar.Visible = false;
                    botonEliminar.Visible = true;
                    botonEliminar.Enabled = false;
                    break;
                case 2:         // para modificar
                    label_subtitulo.Text = "Producto a Modificar";
                    //labelEliminar.Visible = false;
                    cmb_iva.Enabled = true;
                    cmb_Categoria.Enabled = true;
                    BotonLimpiar.Enabled = true;
                    botonModificar.Visible = true;
                    botonModificar.Enabled = false;
                    botonEliminar.Visible = false;
                    break;               
            } 

        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            bool control = false;
            try
            {
                for (int i = 0; i < espacios; i++)
                {
                    if (nombreProducto[i]!= null)
                    {
                        if (nombreProducto[i].ToLower().Trim().Equals(prodELim.ToLower().Trim()) && precioConIva[i]==precioEliminar)
                        {
                            nombreProducto[i] = null;
                            categoriaProducto[i] = null;
                            tipoIva[i] = null;
                            precioSinIva[i] = 0;
                            precioConIva[i] = 0;
                            i = espacios;
                            llenos--;
                            memoriaDisponible();
                            control = true;
                        }

                    }
                    
                }
                if (!control)
                {
                    MessageBox.Show("No se encontró el producto", "No existe el producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                bandera = false;
                mostrarDatos();
                desbloquearEntradas(0);

            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo Eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            desbloquearEntradas(0);
        }

        private void modificarUnProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (llenos == 0)
            {
                mensaje = "No hay registros a modificar.";
                MessageBox.Show(mensaje, "Memoria vacía", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                bandera = true;
                bloquearEntradas(2);
            }
                
        }

        private void botonModificar_Click(object sender, EventArgs e)
        {
            bool res_info, res_precio;
            res_info = ValidarCampos();
            if (res_info)
            {
                res_precio = CalcularIva();

                if (res_precio)
                {
                    try
                    {
                        for (int i = 0; i < espacios; i++)
                        {
                            if (nombreProducto[i] != null)
                            {
                                if (nombreProducto[i].ToLower().Trim().Equals(prodELim.ToLower().Trim()) && precioConIva[i] == precioEliminar)
                                {
                                    nombreProducto[i] = txt_Nombre.Text.ToLower().Trim();
                                    categoriaProducto[i] = txt_Categoria.Text.ToLower().Trim();
                                    tipoIva[i] = cmb_iva.SelectedItem.ToString().ToLower().Trim();
                                    precioSinIva[i] = precioIngresado;
                                    precioConIva[i] = double.Parse(txt_PrecioFinal.Text.ToLower().Trim());
                                    i = espacios;

                                    memoriaDisponible();
                                    desbloquearEntradas(0);
                                    mostrarDatos();
                                    
                                    MessageBox.Show("Se modificó correctamente.", "Cambios realizados", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                }
                            }
                        }
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Ocurrio un error \nal intentar realizar la modificacion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                    
                }
            }


        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarDatos();
            memoriaDisponible();
        }

        private void vaciarTablaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (llenos==0)
            {
                mensaje = "No hay registros a eliminar.";
                MessageBox.Show(mensaje, "Memoria vacía", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult respuesta;
                respuesta = MessageBox.Show("Desea eliminar todos los registros", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    try
                    {
                        vistaProductos.Rows.Clear();

                        for (int i = 0; i < espacios; i++)
                        {
                            nombreProducto[i] = null;
                            categoriaProducto[i] = null;
                            tipoIva[i] = null;
                            precioSinIva[i] = 0;
                            precioConIva[i] = 0;
                            llenos = 0;
                            memoriaDisponible();
                            Limpiar();
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Problemas vaciando la tabla" + ex);
                    }
                }
            }
                 
        }

        private void vistaProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
                
            string itemIva;
            string itemCategoria;
            if (bandera)
            {
                try
                {
                    prodELim = vistaProductos.CurrentRow.Cells[0].Value.ToString();

                    Mod_PSinIva = Convert.ToDouble(vistaProductos.CurrentRow.Cells[3].Value);
                    precioEliminar = Convert.ToDouble(vistaProductos.CurrentRow.Cells[4].Value);
                    txt_Nombre.Text = prodELim;
                    txt_PrecioFinal.Text = precioEliminar.ToString();
                    txt_Precio.Text = Mod_PSinIva.ToString();
                    botonEliminar.Enabled = true;


                    if (botonModificar.Visible)
                    {
                        itemCategoria = vistaProductos.CurrentRow.Cells[1].Value.ToString();
                        txt_Categoria.Text = itemCategoria;
                        itemIva = vistaProductos.CurrentRow.Cells[2].Value.ToString();
                        botonEliminar.Enabled = false;
                        botonModificar.Enabled = true;
                        if (itemIva == "21%")
                        {
                            cmb_iva.SelectedIndex = 0;
                        }
                        else if (itemIva == "10.5%")
                        {
                            cmb_iva.SelectedIndex = 1;
                        }
                        else if (itemIva == "4%")
                        {
                            cmb_iva.SelectedIndex = 3;
                        }
                        else if (itemIva == "27%")
                        {
                            cmb_iva.SelectedIndex = 2;
                        }
                        else
                        {
                            cmb_iva.SelectedIndex = -1;
                        }

                        desbloquearEntradas(1);


                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine( ex + "Error por celda null");
                }

            }

        }

        private void txt_Nombre_MouseClick(object sender, MouseEventArgs e)
        {
            if (txt_Nombre.BackColor == Color.OrangeRed)
            {
                txt_Nombre.BackColor = Color.White;
            }
        }

        private void txt_Precio_MouseClick(object sender, MouseEventArgs e)
        {
            if (txt_Precio.BackColor == Color.OrangeRed)
            {
                txt_Precio.BackColor = Color.White;
            }
        }

        private void cmb_Categoria_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txt_Categoria.Text = cmb_Categoria.SelectedItem.ToString().Trim();
            txt_Categoria.BackColor = Color.White;
        }

        public bool ValidarCampos()
        {
            try
            {
                if (txt_Nombre.Text.Trim() == "" || txt_Categoria.Text.Trim() == "")
                {
                    mensaje = "Se deben completar todos los campos";
                    if (txt_Nombre.Text.Trim() == "")
                    {
                        txt_Nombre.BackColor = Color.OrangeRed;
                    }
                    if (txt_Categoria.Text.Trim() == "")
                    {
                        txt_Categoria.BackColor = Color.OrangeRed;
                    }
                    MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("error al comparar cadenas de los cmb");

            }

            return true;
        }
        public void memoriaDisponible()
        {
            progBar_memoria.Value = llenos;
            
            if ((Convert.ToDouble(llenos) / espacios)>= 0.8)
            {
                if (llenos==espacios)
                {
                    label_pocoEspacio.Text = "Memoria llena";
                    label_pocoEspacio.Visible = true;
                }
                else
                {
                    label_pocoEspacio.Text = "Queda poco espacio";
                    label_pocoEspacio.Visible = true;                   
                }
            }
            else
            {
                label_pocoEspacio.Visible = false;
                
            }
        }

    }


}
