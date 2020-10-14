using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace modelo
{
    public class MProveedor
    {
        public int pk_proveedor { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string ruc { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }
        public double deuda { get; set; }



        //conexion 
        MySqlConnection con = new MySqlConnection("server='localhost';uid='root';password='';database='mysistem';convert zero datetime=True");

        //constructor
        public MProveedor()
        {
            this.pk_proveedor = 0;
            this.nombre = "";
            this.direccion = "";
            this.direccion = "";
            this.ruc = "";
            this.telefono = "";
            this.correo = "";
            this.deuda = 0;

        }

        //validar la conexion
        private void conexion()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }


        //listar
        public DataTable listar()
        {
            conexion();
            string query = "SELECT * FROM proveedor";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            dt.TableName = "proveedor";
            da.Fill(dt);

            cmd.Dispose();
            con.Close();


            return dt;
        }

        public MProveedor insertar(MProveedor obj)
        {
            conexion();
            string query = "INSERT INTO proveedor(nombre, direccion, ruc, telefono, correo, deuda)VALUES('" + obj.nombre + "','" + obj.direccion + "','" + obj.ruc + "','" + obj.telefono + "','" + obj.correo + "','" + obj.deuda + "')";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Close();
            return obj;
        }

        public MProveedor modificar(int pk)
        {
            conexion();
            string query = "SELECT * FROM proveedor WHERE pk_proveedor = '" + pk + "'";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader cursor = cmd.ExecuteReader();

            MProveedor obj = new MProveedor();

            if (cursor.HasRows)
            {
                while (cursor.Read())
                {
                    obj.pk_proveedor = Convert.ToInt32(cursor["pk_proveedor"].ToString());
                    obj.nombre = cursor["nombre"].ToString();
                    obj.direccion = cursor["direccion"].ToString();
                    obj.ruc = cursor["ruc"].ToString();
                    obj.telefono = cursor["telefono"].ToString();
                    obj.correo = cursor["correo"].ToString();
                    obj.deuda = Convert.ToDouble(cursor["deuda"].ToString());
                }
            }

            cursor.Dispose();
            cmd.Dispose();
            con.Close();

            return obj;
        }

        public void actualizar(MProveedor obj)
        {
            conexion();
            string query = "UPDATE proveedor SET nombre= '" + obj.nombre + "',direccion= '" + obj.direccion + "', ruc= '" + obj.ruc + "',telefono = '" + obj.telefono + "'," +
                "correo = '" + obj.correo + "', deuda = '" + obj.deuda + "' WHERE pk_proveedor = '" + obj.pk_proveedor + "'";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Close();
        }

        public void eliminar(int pk)
        {
            conexion();
            string query = "DELETE FROM proveedor WHERE pk_proveedor = '" + pk + "'";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.ExecuteNonQuery();
        }
    }
}
