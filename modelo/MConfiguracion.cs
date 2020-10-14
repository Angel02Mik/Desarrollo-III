using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace modelo
{
    public class MConfiguracion
    {
        public int pk_configuracion { get; set; }
        public string foto { get; set; }

        public string nombre { get; set; }

        //conexion
        MySqlConnection con = new MySqlConnection("server='localhost';uid='root';password='';database='mysistem'");
        public MConfiguracion()
        {
            this.pk_configuracion = 0;
            this.foto = "";
            this.nombre = "";
        }

        private void conexion()
        {
            if(con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }


        public MConfiguracion insertar(MConfiguracion obj)
        {
            conexion();
            string query = "INSERT INTO configuracion(logo,nombre)VALUES('"+obj.foto+ "','" + obj.nombre + "')";
            MySqlCommand cmd = new MySqlCommand(query,con);
            cmd.ExecuteNonQuery();

            return obj;
        }

        public MConfiguracion mostrarNombre()
        {
            conexion();
            string query = "SELECT * FROM configuracion order by pk_configuracion desc limit 1";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader cursor = cmd.ExecuteReader();

            MConfiguracion obj = new MConfiguracion();
            if (cursor.HasRows)
            {
                while (cursor.Read())
                {
                    obj.nombre = cursor["nombre"].ToString();
                }
            }
            cmd.Dispose();
            cursor.Dispose();
            con.Close();

            return obj;
        }

        public MConfiguracion buscarFoto()
        {
            conexion();
            string query = "SELECT * FROM configuracion order by pk_configuracion desc limit 1";
            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataReader cursor = cmd.ExecuteReader();

            MConfiguracion obj = new MConfiguracion();
            if (cursor.HasRows)
            {
                while (cursor.Read())
                {
                    obj.foto = cursor["logo"].ToString();
                }
            }

            cursor.Dispose();
            cmd.Dispose();
            con.Close();

            return obj;
        }
        
    }
}
