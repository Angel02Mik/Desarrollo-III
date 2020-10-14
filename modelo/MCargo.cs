using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;


namespace modelo
{
    public class MCargo
    {

        public int pk_cargo { get; set; }
        public string cargo { get; set; }


        //conexion 
        MySqlConnection con = new MySqlConnection("server='localhost';uid='root';password='';database='mysistem';convert zero datetime=True");

        //constructor
        public MCargo()
        {
            this.pk_cargo = 0;
            this.cargo = "";
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
            string query = "SELECT * FROM cargo";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            dt.TableName = "cargo";
            da.Fill(dt);

            cmd.Dispose();
            con.Close();


            return dt;
        }

        public MCargo insertar(MCargo obj)
        {
            conexion();
            string query = "INSERT INTO cargo(cargo )VALUES('" + obj.cargo + "')";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Close();
            return obj;
        }

        public MCargo modificar(int pk)
        {
            conexion();
            string query = "SELECT * FROM cargo WHERE pk_cargo = '" + pk + "'";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader cursor = cmd.ExecuteReader();

            MCargo obj = new MCargo();

            if (cursor.HasRows)
            {
                while (cursor.Read())
                {
                    obj.pk_cargo = Convert.ToInt32(cursor["pk_cargo"].ToString());
                    obj.cargo = cursor["cargo"].ToString();
                }
            }

            cursor.Dispose();
            cmd.Dispose();
            con.Close();

            return obj;
        }

        public void actualizar(MCargo obj)
        {
            conexion();
            string query = "UPDATE cargo SET cargo= '" + obj.cargo + "' WHERE pk_cargo = '" + obj.pk_cargo + "'";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Close();
        }

        public void eliminar(int pk)
        {
            conexion();
            string query = "DELETE FROM cargo WHERE pk_cargo = '" + pk + "'";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.ExecuteNonQuery();
        }

    }
}
