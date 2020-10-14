using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace modelo
{
    public class MUsuario
    {

        public int pk_usuario { get; set; }
        public string nombre { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string privilegios { get; set; }
        public string estado { get; set; }

        //conexion 
        MySqlConnection con = new MySqlConnection("server='localhost';uid='root';password='';database='mysistem';convert zero datetime=True");

        //constructor
        public MUsuario()
        {
            this.pk_usuario = 0;
            this.nombre = "";
            this.login = "";
            this.password = "";
            this.privilegios = "";
            this.estado = "";

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
            string query = "SELECT * FROM usuario";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            dt.TableName = "usuario";
            da.Fill(dt);

            cmd.Dispose();
            con.Close();


            return dt;
        }

        //cantidad de usuario
        public int cantidadUsuario()
        {
            conexion();
            string query = "SELECT COUNT(*) as totalUsuario FROM usuario ";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader cursor = cmd.ExecuteReader();

            int totalUsuario = 0;
            while (cursor.Read())
            {
                totalUsuario = Convert.ToInt32(cursor["totalUsuario"].ToString());   
            }
            cmd.Dispose();
            cursor.Dispose();
            return totalUsuario;
        }

        //comprobar usuario
        public bool comprobarUsuario(string login,string password)
        {
            conexion();
            string query = "SELECT * FROM usuario WHERE login = '"+login+"' and password = '"+password+"'";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader cursor = cmd.ExecuteReader();

           
            cursor.Read();
            if (cursor.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        //mostrar nombre del usuario
        public MUsuario nombreUsuario(string login)
        {
            conexion();
            string query = "SELECT * FROM usuario WHERE login = '" + login + "'";
            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataReader cursor = cmd.ExecuteReader();

            MUsuario obj = new MUsuario();

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

        public MUsuario insertar(MUsuario obj)
        {
            conexion();
            string query = "INSERT INTO usuario(nombre, login, password, privilegios, estado )VALUES('" + obj.nombre + "','" + obj.login + "','" + obj.password + "','" + obj.privilegios + "','" + obj.estado + "')";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Close();
            return obj;
        }

        public MUsuario modificar(int pk)
        {
            conexion();
            string query = "SELECT * FROM usuario WHERE pk_usuario = '" + pk + "'";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader cursor = cmd.ExecuteReader();

            MUsuario obj = new MUsuario();

            if (cursor.HasRows)
            {
                while (cursor.Read())
                {
                    obj.pk_usuario = Convert.ToInt32(cursor["pk_usuario"].ToString());
                    obj.nombre = cursor["nombre"].ToString();
                    obj.login = cursor["login"].ToString();
                    obj.password = cursor["password"].ToString();
                    obj.privilegios = cursor["privilegios"].ToString();
                    obj.estado = cursor["estado"].ToString();
                }
            }

            cursor.Dispose();
            cmd.Dispose();
            con.Close();

            return obj;
        }

        public void actualizar(MUsuario obj)
        {
            conexion();
            string query = "UPDATE usuario SET nombre= '" + obj.nombre + "',login= '" + obj.login + "',password= '" + obj.password + "', privilegios= '" + obj.privilegios + "', estado= '" + obj.estado + "'  WHERE pk_usuario = '" + obj.pk_usuario + "'";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Close();
        }

        public void eliminar(int pk)
        {
            conexion();
            string query = "DELETE FROM usuario WHERE pk_usuario = '" + pk + "'";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.ExecuteNonQuery();
        }

    }
}
