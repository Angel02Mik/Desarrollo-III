using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using modelo;

namespace controlador
{
    public class CProveedor
    {
        MProveedor objProveedor = new MProveedor();

        public DataView listarProveedor()
        {
            DataView dv = new DataView();
            dv.Table = objProveedor.listar();


            return dv;
        }

        public void insertarProveedor(MProveedor obj)
        {
            objProveedor.insertar(obj);
        }

        public MProveedor modificarProveedor(int pk)
        {
            MProveedor obj = new MProveedor();
            obj = objProveedor.modificar(pk);
            return obj;

        }

        public void actualizarProveedor(MProveedor obj)
        {
            objProveedor.actualizar(obj);
        }

        public void eliminarProveedor(int pk)
        {
            objProveedor.eliminar(pk);
        }
    }
}
