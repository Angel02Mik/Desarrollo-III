using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace modelo
{
    public class MProducto
    {
        public int pk_producto { get; set; }
        public int fk_categoria { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string marca { get; set; }
        public double precio_compra { get; set; }
        public double precio_venta { get; set; }
        public string fecha_compra { get; set; }
        public string fecha_vencimiento { get; set; }
        public double stock { get; set; }
        public string unidad_medida { get; set; }
        public double ganancia { get; set; }
        public string foto { get; set; }


        //conexion 
        MySqlConnection con = new MySqlConnection("server='localhost';uid='root';password='';database='mysistem';convert zero datetime=True");

        //constructor
        public MProducto()
        {
            this.pk_producto = 0;
            this.fk_categoria = 0;
            this.nombre = "";
            this.descripcion = "";
            this.marca = "";
            this.precio_compra = 0;
            this.precio_venta = 0;
            this.fecha_compra = "";
            this.fecha_vencimiento = "";
            this.stock = 0;
            this.unidad_medida = "";
            this.ganancia = 0;
            this.foto = "";
        }

        //validar la conexion
        private void conexion()
        {
            if(con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }


        //listar
        public DataTable listar()
        {
            conexion();
            string query = "SELECT pk_producto,nombre,descripcion,categoria,unidad_medida,marca,precio_venta,fecha_vencimiento,stock,ganancia FROM producto inner join categoria on fk_categoria = pk_categoria";
            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            dt.TableName = "producto";
            da.Fill(dt);

            cmd.Dispose();
            con.Close();
            

            return dt;
        }

        //cantidad de producto
        public int cantidadProducto()
        {
            conexion();
            string query = "SELECT COUNT(*) AS totalProducto FROM producto";
            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataReader cursor = cmd.ExecuteReader();

            int totalProducto = 0;
            while (cursor.Read())
            {
                totalProducto = Convert.ToInt32(cursor["totalProducto"].ToString());
            }
            cursor.Dispose();
            cmd.Dispose();
            con.Close();

            return totalProducto;
        }

        //cantidad de stock de producto
        public int cantidadStock()
        {
            conexion();
            string query = "SELECT SUM(stock) AS totalStock FROM producto";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader cursor = cmd.ExecuteReader();

            int totalStock = 0;

            while (cursor.Read())
            {
                totalStock = Convert.ToInt32(cursor["totalStock"].ToString());
            }
            cmd.Dispose();
            cursor.Dispose();
            con.Close();

            return totalStock;

        }

        public MProducto insertar(MProducto obj)
        {
            conexion();
            string query = "INSERT INTO producto(fk_categoria, nombre, descripcion, marca, precio_compra, precio_venta, fecha_compra, fecha_vencimiento, stock, unidad_medida, ganancia, foto)VALUES('" + obj.fk_categoria+"','"+obj.nombre+"','"+obj.descripcion+"','"+obj.marca+"','"+obj.precio_compra+"','"+obj.precio_venta+"','"+obj.fecha_compra+"','"+obj.fecha_vencimiento+"','"+obj.stock+"','"+obj.unidad_medida+"','"+obj.ganancia+"','"+obj.foto+"')";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Close();
            return obj;
        }

        public MProducto modificar(int pk)
        {
            conexion();
            string query = "SELECT * FROM producto WHERE pk_producto = '" + pk + "'";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader cursor = cmd.ExecuteReader();

            MProducto obj = new MProducto();

            if (cursor.HasRows)
            {
                while (cursor.Read())
                {
                    obj.pk_producto = Convert.ToInt32(cursor["pk_producto"].ToString());
                    obj.fk_categoria = Convert.ToInt32(cursor["fk_categoria"].ToString());
                    obj.nombre = cursor["nombre"].ToString();
                    obj.descripcion = cursor["descripcion"].ToString();
                    obj.marca = cursor["marca"].ToString();
                    obj.precio_compra = Convert.ToDouble(cursor["precio_compra"].ToString());
                    obj.precio_venta = Convert.ToDouble(cursor["precio_venta"].ToString());
                    obj.fecha_compra = cursor["fecha_compra"].ToString();
                    obj.fecha_vencimiento = cursor["fecha_vencimiento"].ToString();
                    obj.stock = Convert.ToDouble(cursor["stock"].ToString());
                    obj.unidad_medida = cursor["unidad_medida"].ToString();
                }
            }

            cursor.Dispose();
            cmd.Dispose();
            con.Close();

            return obj;
        }

        public void actualizar(MProducto obj)
        {
            conexion();
            string query = "UPDATE producto SET fk_categoria= '" + obj.fk_categoria + "',nombre= '" + obj.nombre+ "',descripcion= '" + obj.descripcion + "',marca= '" + obj.marca + "', precio_compra= '" + obj.precio_compra + "',precio_venta = '" + obj.precio_venta + "'," +
                "fecha_compra = '" + obj.fecha_compra + "', fecha_vencimiento = '" + obj.fecha_vencimiento + "',stock = '" + obj.stock + "', unidad_medida = '" + obj.unidad_medida + "',ganancia= '" + obj.ganancia + "' WHERE pk_producto = '"+obj.pk_producto+"'";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Close();
        }

        public void eliminar(int pk)
        {
            conexion();
            string query = "DELETE FROM producto WHERE pk_producto = '" + pk + "'";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.ExecuteNonQuery();
        }
    }
}
