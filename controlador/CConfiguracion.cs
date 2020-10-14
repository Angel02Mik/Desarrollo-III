using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using modelo;
using System.Data;

namespace controlador
{
   
    public class CConfiguracion
    {
        MConfiguracion objConfiguracion = new MConfiguracion();

        public void insertarConfiguracion(MConfiguracion obj)
        {
            objConfiguracion.insertar(obj);
        }

        public MConfiguracion mostrarNombre()
        {
            MConfiguracion obj = new MConfiguracion();
            obj = objConfiguracion.mostrarNombre();

            return obj;
        }
        public MConfiguracion mostrarFoto()
        {
            MConfiguracion obj = new MConfiguracion();

            obj = objConfiguracion.buscarFoto();

            return obj;
        }
    }
}
