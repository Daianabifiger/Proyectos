using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    public class Producto
    {
        //_ es porq no son accesibles porq son privadas
        private int _codigo;
        private string _descripcion;
        private double _precioCompra;
        private double _precioVenta;
        private string _categoria;

        //constructores -- Constructor por defecto
        public Producto(int codigo, string descripcion, string categoria, double precioCompra, double precioVenta)
        {
            this._codigo = codigo;
            this._descripcion = descripcion;
            this._categoria = categoria;
            this._precioCompra = precioCompra;
            this._precioVenta = precioVenta;
        }

        public string categoria
        {
            get
            {
                if (!string.IsNullOrEmpty(this._categoria))
                {
                    return this._categoria;
                }
                else
                {
                    return "SIN CATEGORIA";
                }
            }
            set
            {
                this._categoria = value;
            }
        }

        public bool hayPrecioDeVenta()
        {
            return this._precioVenta > 0;
        }
    }
}
