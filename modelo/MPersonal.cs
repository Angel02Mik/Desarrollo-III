using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace modelo
{
    public class MPersonal
    {
        public int pk_personal { get; set; }
        public int fk_cargo { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string sexo { get; set; }
        public string dni { get; set; }
        public string direccion { get; set; }
        public int telefono { get; set; }

        //conexion 
        MySqlConnection con = new MySqlConnection("server='localhost';uid='root';password='';database='mysistem';convert zero datetime=True");

        //constructor
        public MPersonal()
        {
            this.pk_personal = 0;
            this.fk_cargo = 0;
            this.nombres = "";
            this.apellidos = "";
            this.sexo = "";
            this.dni = "";
            this.direccion = "";
            this.telefono = 0;

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
            string query = "SELECT * FROM personal";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            dt.TableName = "personal";
            da.Fill(dt);

            cmd.Dispose();
            con.Close();


            return dt;
        }

        public int cantidadPersonal()
        {
            conexion();
            string query = "SELECT COUNT(*) AS totalPersonal FROM personal";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader cursor = cmd.ExecuteReader();

            int totalPersonal = 0;
            while (cursor.Read())
            {
                totalPersonal = Convert.ToInt32(cursor["totalPersonal"].ToString());
            }
            cmd.Dispose();
            cursor.Dispose();
            con.Close();

            return totalPersonal;
        }
        public MPersonal insertar(MPersonal obj)
        {
            conexion();
            string query = "INSERT INTO personal(fk_cargo, nombres, apellidos, sexo, dni, direccion, telefono )VALUES('" + obj.fk_cargo + "','" + obj.nombres + "','" + obj.apellidos + "','" + obj.sexo + "','" + obj.dni + "','" + obj.direccion + "','" + obj.telefono + "')";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Close();
            return obj;
        }

        public MPersonal modificar(int pk)
        {
            conexion();
            string query = "SELECT * FROM personal WHERE pk_personal = '" + pk + "'";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader cursor = cmd.ExecuteReader();

            MPersonal obj = new MPersonal();

            if (cursor.HasRows)
            {
                while (cursor.Read())
                {
                    obj.pk_personal = Convert.ToInt32(cursor["pk_personal"].ToString());
                    obj.fk_cargo = Convert.ToInt32(cursor["fk_cargo"].ToString());
                    obj.nombres = cursor["nombres"].ToString();
                    obj.apellidos = cursor["apellidos"].ToString();
                    obj.sexo = cursor["sexo"].ToString();
                    obj.dni = cursor["dni"].ToString();
                    obj.direccion = cursor["direccion"].ToString();
                    obj.telefono = Convert.ToInt32(cursor["telefono"].ToString());

                }
            }

            cursor.Dispose();
            cmd.Dispose();
            con.Close();

            return obj;
        }

        public void actualizar(MPersonal obj)
        {
            conexion();
            string query = "UPDATE personal SET fk_cargo = '"+obj.fk_cargo+"', nombres= '" + obj.nombres + "',apellidos= '" + obj.apellidos + "',sexo= '" + obj.sexo + "', dni= '" + obj.dni + "', direccion= '" + obj.direccion + "', telefono= '" + obj.telefono + "' WHERE pk_personal = '" + obj.pk_personal + "'";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Close();
        }

        public void eliminar(int pk)
        {
            conexion();
            string query = "DELETE FROM personal WHERE pk_personal = '" + pk + "'";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.ExecuteNonQuery();
        }
    }
}
