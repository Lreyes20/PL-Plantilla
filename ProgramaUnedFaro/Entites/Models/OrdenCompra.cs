using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.Models
{
     public class OrdenCompra
    {
        private int id;
        private DateTime fecha;
        private Vendedor vendedor_compra;
        private OrdenCompraDetalle[] orden_compra_detalle = new OrdenCompraDetalle[15];
        private int orden_compra_detalle_cantidad = 0;

        public OrdenCompra()
        {
        }

        public OrdenCompra(int id, DateTime fecha, Vendedor vendedor_compra)
        {
            this.id = id;
            this.fecha = fecha;
            this.vendedor_compra = vendedor_compra;
        }

        public int Id { get => id; set => id = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public Vendedor Vendedor_compra { get => vendedor_compra; set => vendedor_compra = value; }
        public OrdenCompraDetalle[] Orden_compra_detalle { get => orden_compra_detalle; set => orden_compra_detalle = value; }
        public int Orden_compra_detalle_cantidad { get => orden_compra_detalle_cantidad; set => orden_compra_detalle_cantidad = value; }

        public override string ToString()
        {
            String orden = "";

            for (int i = 0; i < orden_compra_detalle_cantidad; i++)
            {
                orden += orden_compra_detalle[i].ToString();
            }

            return orden;
        }

        public decimal TotalVendedor()
        {
            decimal resultado = 0;

            for (int i = 0; i < orden_compra_detalle_cantidad; i++)
            {
                resultado += orden_compra_detalle[i].PV();
            }

            return resultado;
        }

        public decimal TotalFinal()
        {
            decimal resultado = 0;

            for (int i = 0; i < orden_compra_detalle_cantidad; i++)
            {
                resultado += orden_compra_detalle[i].PF();
            }

            return resultado;
        }
    }
}

