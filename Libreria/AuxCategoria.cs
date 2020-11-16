using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public class AuxCategoria
    {
        //private List<Categoria> DatosCategorias = new List<Categoria>();

        private List<Categoria> DatosCategorias; 

        /// <summary>
        /// Agrega una nueva categoría siempre que esta no exista
        /// </summary>
        /// <param name="Nueva">La nueva categoría a agregar</param>
        /// <returns>1 si la agrega sino 0</returns>
        public int Agregar(Categoria Nueva)
        {
            int res = 0;

            DatosCategorias.Add(Nueva);
            res = 1;

            return res;
        }

        public int Agregar(int idcat, string nom, string desc)
        {
            int res = 0;
            Categoria nueva = new Categoria(idcat, nom, desc);

            DatosCategorias.Add(nueva);
            res = 1;
            
            return res;
        }

        public int Eliminar(int idCat)
        {
            int res = 0;
            Categoria categoriaEncontrada = null;
            categoriaEncontrada = Buscar(idCat);

            if(categoriaEncontrada!=null)
            {
                DatosCategorias.Remove(categoriaEncontrada);
                res = 1;
            }
            return res;
        }

        /// <summary>
        /// Modifica una categoría basada en los datos de una categoría ya existente
        /// </summary>
        /// <param name="CatModificada">La categoría modificada</param>
        /// <returns>1 si la modificó sino 0</returns>
        public int Modificar(Categoria CatModificada)
        {
            int res = 0;

            if(Buscar(CatModificada.Idcategoria)!=null)
            {
                int pos = Posicion(CatModificada.Idcategoria);
                if(pos>=0)
                {
                    DatosCategorias[pos+1].Idcategoria = CatModificada.Idcategoria;
                    DatosCategorias[pos+1].Nombre = CatModificada.Nombre;
                    DatosCategorias[pos+1].Descripcion = CatModificada.Descripcion;
                    res = 1;
                }
            }

            return res;
        }

        public int Modificar(int idCategoria, string nuevoNombre, string nuevaDescripcion)
        {
            int res = 0;

            int pos = Posicion(idCategoria);

            if(pos>=0)
            {
                DatosCategorias[pos].Nombre = nuevoNombre;
                DatosCategorias[pos].Descripcion = nuevaDescripcion;
                res = 1;
            }
            
            return res;
        }

        /// <summary>
        /// Busca una categoría usando como parámetro el ID
        /// </summary>
        /// <param name="idcat">id de la categoría</param>
        /// <returns>null si no la encuentra o el objeto categoría completo si la encuentra</returns>
        private Categoria Buscar(int idcat)
        {
            Categoria cat = null;

            foreach (Categoria c in DatosCategorias)
            {
                if (c.Idcategoria == idcat)
                {
                    //cat = c;
                    break;
                }
            }

            return cat;
        }

        private int Posicion(int idCat)
        {
            int res = -1;
            int p = -1;
            foreach(Categoria c in DatosCategorias)
            {
                p = p++;
                if(c.Idcategoria==idCat)
                {
                    res = p;
                    break;
                }
            }
            return res;
        }
    }
}
