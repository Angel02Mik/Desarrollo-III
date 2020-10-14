using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace modelo
{
    public class MCategoria
    {

        public int pk_categoria { get; set; }
        public string categoria { get; set; }
        public string foto_cat { get; set; }


        //conexion 
        MySqlConnection con = new MySqlConnection("server='localhost';uid='root';password='';database='mysistem';convert zero datetime=True");

        //constructor
        public MCategoria()
        {
            this.pk_categoria = 0;
            this.categoria = "";
            this.foto_cat = "";
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
            string query = "SELECT * FROM categoria ";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            dt.TableName = "categoria";
            da.Fill(dt);

            cmd.Dispose();
            con.Close();


            return dt;
        }

        public MCategoria insertar(MCategoria obj)
        {
            conexion();
            string query = "INSERT INTO categoria(categoria)VALUES('" + obj.categoria + "')";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Close();
            return obj;
        }

        public MCategoria modificar(int pk)
        {
            conexion();
            string query = "SELECT * FROM categoria WHERE pk_categoria = '" + pk + "'";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader cursor = cmd.ExecuteReader();

            MCategoria obj = new MCategoria();

            if (cursor.HasRows)
            {
                while (cursor.Read())
                {
                    obj.pk_categoria = Convert.ToInt32(cursor["pk_categoria"].ToString());
                    obj.categoria = cursor["categoria"].ToString();
                }
            }

            cursor.Dispose();
            cmd.Dispose();
            con.Close();

            return obj;
        }

        public void actualizar(MCategoria obj)
        {
            conexion();
            string query = "UPDATE categoria SET categoria= '" + obj.categoria + "' WHERE pk_categoria = '"+obj.pk_categoria+"'";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Close();
        }

        public void eliminar(int pk)
        {
            conexion();
            string query = "DELETE FROM categoria WHERE pk_categoria = '" + pk + "'";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.ExecuteNonQuery();
        }
    }
}
