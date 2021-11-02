using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.Models
{
    public class Articulo
    {
        private int id;
        private string descripcion;
        private bool activo;
        private decimal precio_vendedor;
        private decimal precio_Final;
        private int cantidad_disponible;

        public Articulo()
        {
        }

        public Articulo(int id, string descripcion, bool activo, decimal precio_vendedor, decimal precio_Final, int cantidad_disponible)
        {
            this.id = id;
            this.descripcion = descripcion;
            this.activo = activo;
            this.precio_vendedor = precio_vendedor;
            this.precio_Final = precio_Final;
            this.cantidad_disponible = cantidad_disponible;
        }

        public int Id { get => id; set => id = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public bool Activo { get => activo; set => activo = value; }
        public decimal Precio_vendedor { get => precio_vendedor; set => precio_vendedor = value; }
        public decimal Precio_Final { get => precio_Final; set => precio_Final = value; }
        public int Cantidad_Disponible { get => cantidad_disponible; set => cantidad_disponible = value; }

        public override string ToString()
        {
            return Id + ":" + Descripcion;
        }
    }
}

