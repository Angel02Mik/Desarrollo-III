using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using modelo;
using System.Data;

namespace controlador
{
    public class CCategoria
    {
       MCategoria objCategoria = new MCategoria();

        public DataView listarCategoria()
        {
            DataView dv = new DataView();
            dv.Table = objCategoria.listar();


            return dv;
        }

        public void insertarCategoria(MCategoria obj)
        {
            objCategoria.insertar(obj);
        }

        public MCategoria modificarCategoria(int pk)
        {
           MCategoria obj = new MCategoria();
            obj = objCategoria.modificar(pk);
            return obj;

        }

        public void actualizarCategoria(MCategoria obj)
        {
            objCategoria.actualizar(obj);
        }

        public void eliminarCategoria(int pk)
        {
            objCategoria.eliminar(pk);
        }
    }
}
