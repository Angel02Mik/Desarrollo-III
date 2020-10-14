using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using modelo;

namespace controlador
{
    public class CCargo
    {
        MCargo objCargo = new MCargo();

        public DataView listarCargo()
        {
            DataView dv = new DataView();
            dv.Table = objCargo.listar();


            return dv;
        }

        public void insertarCargo(MCargo obj)
        {
            objCargo.insertar(obj);
        }

        public MCargo modificarCargo(int pk)
        {
            MCargo obj = new MCargo();
            obj = objCargo.modificar(pk);
            return obj;

        }

        public void actualizarCargo(MCargo obj)
        {
            objCargo.actualizar(obj);
        }

        public void eliminarCargo(int pk)
        {
            objCargo.eliminar(pk);
        }
    }
}
