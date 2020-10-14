using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace modelo
{
    public class MCliente
    {
        public int pk_cliente { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string direccion { get; set; }
        public int dni { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }
        public double deuda { get; set; }
   


        //conexion 
        MySqlConnection con = new MySqlConnection("server='localhost';uid='root';password='';database='mysistem';convert zero datetime=True");

        //constructor
        public MCliente()
        {
            this.pk_cliente = 0;
            this.nombres = "";
            this.apellidos = "";
            this.direccion = "";
            this.dni = 0;
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
            string query = "SELECT * FROM cliente";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            dt.TableName = "cliente";
            da.Fill(dt);

            cmd.Dispose();
            con.Close();


            return dt;
        }

        public MCliente insertar(MCliente obj)
        {
            conexion();
            string query = "INSERT INTO cliente(nombres, apellidos, direccion, dni, telefono, correo, deuda)VALUES('" + obj.nombres + "','" + obj.apellidos + "','" + obj.direccion + "','" + obj.dni + "','" + obj.telefono + "','" + obj.correo + "','" + obj.deuda + "')";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Close();
            return obj;
        }

        public int cantidadCliente()
        {
            conexion();
            string query = "SELECT COUNT(*) AS totalCliente FROM cliente";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader cursor = cmd.ExecuteReader();

            int totalCliente = 0;

            while (cursor.Read())
            {
                totalCliente = Convert.ToInt32(cursor["totalCliente"].ToString());
            }

            cmd.Dispose();
            cursor.Dispose();
            con.Close();

            return totalCliente;

        }
        public MCliente modificar(int pk)
        {
            conexion();
            string query = "SELECT * FROM cliente WHERE pk_cliente = '" + pk + "'";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader cursor = cmd.ExecuteReader();

            MCliente obj = new MCliente();

            if (cursor.HasRows)
            {
                while (cursor.Read())
                {
                    obj.pk_cliente = Convert.ToInt32(cursor["pk_cliente"].ToString());
                    obj.nombres = cursor["nombres"].ToString();
                    obj.apellidos = cursor["apellidos"].ToString();
                    obj.direccion = cursor["direccion"].ToString();
                    obj.dni = Convert.ToInt32(cursor["dni"].ToString());
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

        public void actualizar(MCliente obj)
        {
            conexion();
            string query = "UPDATE cliente SET nombres= '" + obj.nombres + "',apellidos= '" + obj.apellidos + "',direccion= '" + obj.direccion + "', dni= '" + obj.dni + "',telefono = '" + obj.telefono + "'," +
                "correo = '" + obj.correo + "', deuda = '" + obj.deuda + "' WHERE pk_cliente = '" + obj.pk_cliente + "'";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Close();
        }

        public void eliminar(int pk)
        {
            conexion();
            string query = "DELETE FROM cliente WHERE pk_cliente = '" + pk + "'";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.ExecuteNonQuery();
        }
    }
}
