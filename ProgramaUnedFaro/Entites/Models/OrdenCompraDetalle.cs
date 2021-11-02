using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.Models
{
    public class OrdenCompraDetalle
    {
        private Articulo articulo_detalle;
        private int cantidad;

        public OrdenCompraDetalle()
        {
        }

        public OrdenCompraDetalle(Articulo articulo_detalle, int cantidad)
        {
            this.articulo_detalle = articulo_detalle;
            this.cantidad = cantidad;
        }

        public Articulo Articulo_detalle { get => articulo_detalle; set => articulo_detalle = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }

        public decimal PV()
        {
            return articulo_detalle.Precio_vendedor * cantidad;
        }

        public decimal PF()
        {
            return articulo_detalle.Precio_Final * cantidad;
        }
        public override string ToString()
        {
            return "(" + articulo_detalle.Descripcion + "*" + cantidad + " PV= " + PV() + " PF= " + PF() + ")";
        }
    }
}
