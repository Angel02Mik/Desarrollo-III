using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using modelo;
using System.Data;

namespace controlador
{
    public class CProducto
    {
        MProducto objProducto = new MProducto();

        public DataView listarProducto()
        {
            DataView dv = new DataView();
            dv.Table = objProducto.listar();


            return dv;
        }

        public void insertarProducto(MProducto obj)
        {
            objProducto.insertar(obj);
        }

        public MProducto modificarProducto(int pk)
        {
            MProducto obj = new MProducto();
            obj = objProducto.modificar(pk);
            return obj;
            
        }

        public int cantidadProducto()
        {
            int totalProducto = 0;
            totalProducto = objProducto.cantidadProducto();

            return totalProducto;
        }

        public int cantidadStock()
        {
            int totalStock = 0;
            totalStock = objProducto.cantidadStock();
            return totalStock;
        }

        public void actualizarProducto(MProducto obj)
        {
            objProducto.actualizar(obj);
        }

        public void eliminarProducto(int pk)
        {
            objProducto.eliminar(pk);
        }
    }
}
