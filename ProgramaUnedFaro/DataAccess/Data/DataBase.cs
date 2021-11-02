using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entites.Models;

namespace DataAccess.Data
{
    public class DataBase
    {
        public const int MAXIMO = 20;
        public const int MAXIMO_COMPRA = 15;

        public static Articulo[] articulos = new Articulo[MAXIMO];
        public static Vendedor[] vendedores = new Vendedor[MAXIMO];
        public static OrdenCompra[] ordenes = new OrdenCompra[MAXIMO];

        public static int CONT_ARTICULOS = 0;
        public static int CONT_VENDEDORES = 0;
        public static int CONT_ORDENES = 0;
    }
}

