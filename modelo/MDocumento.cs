using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace modelo
{
    public class MDocumento
    {
        public int pk_documento { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string serie { get; set; }
        public string numero { get; set; }
       
        //conexion 
        MySqlConnection con = new MySqlConnection("server='localhost';uid='root';password='';database='mysistem';convert zero datetime=True");

        //constructor
        public MDocumento()
        {
            this.pk_documento = 0;
            this.codigo = "";
            this.nombre = "";
            this.serie = "";
            this.numero = "";

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
            string query = "SELECT * FROM documento";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            dt.TableName = "documento";
            da.Fill(dt);

            cmd.Dispose();
            con.Close();


            return dt;
        }

        public MDocumento insertar(MDocumento obj)
        {
            conexion();
            string query = "INSERT INTO documento(codigo, nombre, serie, numero)VALUES('" + obj.codigo + "','" + obj.nombre + "','" + obj.serie + "','" + obj.numero + "')";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Close();
            return obj;
        }

        public MDocumento modificar(int pk)
        {
            conexion();
            string query = "SELECT * FROM documento WHERE pk_documento = '" + pk + "'";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader cursor = cmd.ExecuteReader();

            MDocumento obj = new MDocumento();

            if (cursor.HasRows)
            {
                while (cursor.Read())
                {
                    obj.pk_documento = Convert.ToInt32(cursor["pk_documento"].ToString());
                    obj.codigo = cursor["codigo"].ToString();
                    obj.nombre = cursor["nombre"].ToString();
                    obj.serie = cursor["serie"].ToString();
                    obj.numero = cursor["numero"].ToString();
                   
                }
            }

            cursor.Dispose();
            cmd.Dispose();
            con.Close();

            return obj;
        }

        public void actualizar(MDocumento obj)
        {
            conexion();
            string query = "UPDATE documento SET codigo= '" + obj.codigo + "',nombre= '" + obj.nombre + "',serie= '" + obj.serie + "', numero= '" + obj.numero + "' WHERE pk_documento = '" + obj.pk_documento + "'";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Close();
        }

        public void eliminar(int pk)
        {
            conexion();
            string query = "DELETE FROM documento WHERE pk_documento = '" + pk + "'";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.ExecuteNonQuery();
        }
    }
}
