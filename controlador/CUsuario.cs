using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using modelo;
using System.Data;

namespace controlador
{
    public class CUsuario
    {
        MUsuario objUsuario = new MUsuario();

        public DataView listarUsuario()
        {
            DataView dv = new DataView();
            dv.Table = objUsuario.listar();


            return dv;
        }

        public void insertarUsuario(MUsuario obj)
        {
            objUsuario.insertar(obj);
        }

        public MUsuario modificarUsuario(int pk)
        {
            MUsuario obj = new MUsuario();
            obj = objUsuario.modificar(pk);
            return obj;
        }

        public MUsuario nombreUsuario(string login)
        {
            MUsuario obj = new MUsuario();
            obj = objUsuario.nombreUsuario(login);

            return obj;
        }

        public int cantidadUsuario()
        {
            int totalUsuario = 0;

            totalUsuario = objUsuario.cantidadUsuario();

            return totalUsuario;
        }

        public void actualizarUsuario(MUsuario obj)
        {
            objUsuario.actualizar(obj);
        }

        public void eliminarUsuario(int pk)
        {
            objUsuario.eliminar(pk);
        }
    }
}
