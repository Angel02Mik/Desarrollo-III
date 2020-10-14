using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using modelo;
using System.Data;

namespace controlador
{
    public class CCliente
    {
        MCliente objCliente = new MCliente();

        public DataView listarCliente()
        {
            DataView dv = new DataView();
            dv.Table = objCliente.listar();


            return dv;
        }

        public void insertarCliente(MCliente obj)
        {
            objCliente.insertar(obj);
        }

        public MCliente modificarCliente(int pk)
        {
            MCliente obj = new MCliente();
            obj = objCliente.modificar(pk);
            return obj;

        }

        public int cantidadCliente()
        {
            int totalCliente = 0;
            totalCliente = objCliente.cantidadCliente();

            return totalCliente;
        }

        public void actualizarCliente(MCliente obj)
        {
            objCliente.actualizar(obj);
        }

        public void eliminarCliente(int pk)
        {
            objCliente.eliminar(pk);
        }
    }
}
