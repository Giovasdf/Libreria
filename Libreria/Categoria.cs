using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public class Categoria
    {
        private int idcategoria;
        private string nombre;
        private string descripcion;

        public Categoria()
        {

        }

        public Categoria(int idcategoria, string nombre, string descripcion)
        {
            this.Idcategoria = idcategoria;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
        }

        public int Idcategoria { get => idcategoria; set => idcategoria = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
