using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using modelo;
using System.Data;

namespace controlador
{
    public class CUnidad_medida
    {
        MUnidad_medida objUnidad_medida = new MUnidad_medida();

        public DataView listarUnidad_medida()
        {
            DataView dv = new DataView();
            dv.Table = objUnidad_medida.listar();


            return dv;
        }

        public void insertarUnidad_medida(MUnidad_medida obj)
        {
            objUnidad_medida.insertar(obj);
        }

        public MUnidad_medida modificarUnidad_medida(int pk)
        {
            MUnidad_medida obj = new MUnidad_medida();
            obj = objUnidad_medida.modificar(pk);
            return obj;

        }

        public void actualizarUnidad_medida(MUnidad_medida obj)
        {
            objUnidad_medida.actualizar(obj);
        }

        public void eliminarUnidad_medida(int pk)
        {
            objUnidad_medida.eliminar(pk);
        }
    }
}
