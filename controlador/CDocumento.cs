using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using modelo;

namespace controlador
{
    public class CDocumento
    {
        MDocumento objDocumento = new MDocumento();

        public DataView listarDocumento()
        {
            DataView dv = new DataView();
            dv.Table = objDocumento.listar();


            return dv;
        }

        public void insertarDocumento(MDocumento obj)
        {
            objDocumento.insertar(obj);
        }

        public MDocumento modificarDocumento(int pk)
        {
            MDocumento obj = new MDocumento();
            obj = objDocumento.modificar(pk);
            return obj;

        }

        public void actualizarDocumento(MDocumento obj)
        {
            objDocumento.actualizar(obj);
        }

        public void eliminarDocumento(int pk)
        {
            objDocumento.eliminar(pk);
        }
    }
}
