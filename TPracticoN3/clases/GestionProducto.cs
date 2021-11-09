using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPracticoN3.clases;

namespace TPracticoN3.clases
{
    class GestionProducto
    {

        Producto[] productos;
        public GestionProducto()
        {
            
            
        }


        public bool AgregarProducto(Producto prod)
        {
            bool resultado = false;
            try
            {
                Redimensionar();
                productos[productos.Length - 1] = prod;
                resultado = true;
            }
            catch (Exception e)
            {

                Console.WriteLine("error en la guardado" + e);
            }

            return resultado;


        }
        public void EliminarProducto()
        {

        }
        public void modificarProducto()
        {

        }
        public void Redimensionar()
        {
            if (productos == null)
            {
                productos = new Producto[1];
            }
            else
            {
                Producto[] aux = new Producto[productos.Length + 1];
                for (int i = 0; i < productos.Length; i++)
                {
                    aux[i] = productos[i];
                }
                productos = aux;
            }

        }
    }
}
