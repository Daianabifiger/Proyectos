using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    public class ProductosConE
    {
        private List<Producto> _productosconE;

        public ProductosConE() 
        {
            _productosconE = new List<Producto>();
        }

        public void InsertarEnLista(Producto[] arrayProductos)
        {
            for (int i = 0; i < arrayProductos.Length; i++)
            {
                if (arrayProductos[i].Descripcion.Contains("E") || arrayProductos[i].Descripcion.Contains("e"))
                {
                    _productosconE.Add(new Producto(arrayProductos[i].Codigo, arrayProductos[i].Descripcion));
                }
               
            }
        }

        public List<Producto> MostrarLista()
        {
            return _productosconE;
        }

        public void LimpiarLista()
        {
            _productosconE.Clear();
        }
    }
}
