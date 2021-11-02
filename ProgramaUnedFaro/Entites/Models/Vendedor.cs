using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.Models
{
    public class Vendedor
    {
        private string identificacion;
        private string nombre;
        private string primer_apellido;
        private string segundo_apellido;
        private DateTime fecha_nacimiento;
        private char genero;
        private DateTime fecha_ingreso;

        public Vendedor()
        {
        }

        public Vendedor(string identificacion, string nombre, string primer_apellido, string segundo_apellido, DateTime fecha_nacimiento, char genero, DateTime fecha_ingreso)
        {
            this.Identificacion = identificacion;
            this.Nombre = nombre;
            this.Primer_apellido = primer_apellido;
            this.Segundo_apellido = segundo_apellido;
            this.Fecha_nacimiento = fecha_nacimiento;
            this.Genero = genero;
            this.Fecha_ingreso = fecha_ingreso;
        }

        public string Identificacion { get => identificacion; set => identificacion = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Primer_apellido { get => primer_apellido; set => primer_apellido = value; }
        public string Segundo_apellido { get => segundo_apellido; set => segundo_apellido = value; }
        public DateTime Fecha_nacimiento { get => fecha_nacimiento; set => fecha_nacimiento = value; }
        public char Genero { get => genero; set => genero = value; }
        public DateTime Fecha_ingreso { get => fecha_ingreso; set => fecha_ingreso = value; }

        public override string ToString()
        {
            return Identificacion + ":" + Nombre + " " + Primer_apellido + " " + Segundo_apellido;
        }
    }
}
