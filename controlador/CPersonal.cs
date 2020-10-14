using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using modelo;
using System.Data;

namespace controlador
{
    public class CPersonal
    {
        MPersonal objPersonal = new MPersonal();

        public DataView listarPersonal()
        {
            DataView dv = new DataView();
            dv.Table = objPersonal.listar();


            return dv;
        }

        public void insertarPersonal(MPersonal obj)
        {
            objPersonal.insertar(obj);
        }

        public MPersonal modificarPersonal(int pk)
        {
            MPersonal obj = new MPersonal();
            obj = objPersonal.modificar(pk);
            return obj;

        }

        public int cantidadPersonal()
        {
            int totalPersonal = 0;
            totalPersonal = objPersonal.cantidadPersonal();

            return totalPersonal;
        }
        public void actualizarPersonal(MPersonal obj)
        {
            objPersonal.actualizar(obj);
        }

        public void eliminarPersonal(int pk)
        {
            objPersonal.eliminar(pk);
        }
    }
}
