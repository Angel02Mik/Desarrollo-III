using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace modelo
{
    public class MUnidad_medida
    {
        public int pk_unidad_medida { get; set; }
        public string unidad_medida { get; set; }
        public string moneda { get; set; }


        //conexion 
        MySqlConnection con = new MySqlConnection("server='localhost';uid='root';password='';database='mysistem';convert zero datetime=True");

        //constructor
        public MUnidad_medida()
        {
            this.pk_unidad_medida = 0;
            this.unidad_medida = "";
            this.moneda = "";
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
            string query = "SELECT * FROM unidad_medida";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            dt.TableName = "unidad_medida";
            da.Fill(dt);

            cmd.Dispose();
            con.Close();


            return dt;
        }

        public MUnidad_medida insertar(MUnidad_medida obj)
        {
            conexion();
            string query = "INSERT INTO unidad_medida(unidad_medida,moneda )VALUES('" + obj.unidad_medida + "','" + obj.moneda + "')";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Close();
            return obj;
        }

        public MUnidad_medida modificar(int pk)
        {
            conexion();
            string query = "SELECT * FROM unidad_medida WHERE pk_unidad_medida = '" + pk + "'";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader cursor = cmd.ExecuteReader();

            MUnidad_medida obj = new MUnidad_medida();

            if (cursor.HasRows)
            {
                while (cursor.Read())
                {
                    obj.pk_unidad_medida = Convert.ToInt32(cursor["pk_unidad_medida"].ToString());
                    obj.unidad_medida = cursor["unidad_medida"].ToString();
                    obj.moneda = cursor["moneda"].ToString();
                }
            }

            cursor.Dispose();
            cmd.Dispose();
            con.Close();

            return obj;
        }

        public void actualizar(MUnidad_medida obj)
        {
            conexion();
            string query = "UPDATE unidad_medida SET unidad_medida= '" + obj.unidad_medida + "', moneda='"+obj.moneda+"' WHERE pk_unidad_medida = '" + obj.pk_unidad_medida + "'";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Close();
        }

        public void eliminar(int pk)
        {
            conexion();
            string query = "DELETE FROM unidad_medida WHERE pk_unidad_medida = '" + pk + "'";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.ExecuteNonQuery();
        }
    }
}
