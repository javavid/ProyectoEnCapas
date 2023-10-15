using System;
using MySql.Data.MySqlClient;
using CapaEntidad;
using System.Windows.Forms;
using System.Data;

namespace CapaDatos
{
    public class CDlogueo
    {
        string cadenaconexion = "Server=localhost;User=root;Password=EderJavavid54321;port=3306;database=base_sistema_pos";


        public void PruebaConexion() 
        {
         MySqlConnection conexion = new MySqlConnection(cadenaconexion);

            try
            {
                conexion.Open();
            }
            catch (Exception ex) 
            {
             MessageBox.Show("error al conectarse a la DB" + ex.Message);
                return;
            }
            conexion.Close();
            MessageBox.Show("conectado exitosamente  a la DB");
        }

        public void Crear(CElogueo ce)
        {
            MySqlConnection mySqlConnection1 = new MySqlConnection(cadenaconexion);
            mySqlConnection1.Open();
            string Query = "INSERT INTO `base_sistema_pos`.`clientes` (`nombre`, `apellido`, `foto`) VALUES ('" + ce.nombre + "', '" + ce.apellido + "','" + MySql.Data.MySqlClient.MySqlHelper.EscapeString(ce.foto) + "');";
            MySqlCommand mySqlCommand1 = new MySqlCommand(Query, mySqlConnection1);
            mySqlCommand1.ExecuteNonQuery();
            mySqlConnection1.Close();
            MessageBox.Show("Registro insertado exictosamente");

        }

        public void Editar(CElogueo ce)
        {
            MySqlConnection mySqlConnection1 = new MySqlConnection(cadenaconexion);
            mySqlConnection1.Open();
            string Query  = "UPDATE `base_sistema_pos`.`clientes` SET `nombre` = '" + ce.nombre + "', `apellido` = '" + ce.apellido + " ', `foto` = '" + MySql.Data.MySqlClient.MySqlHelper.EscapeString(ce.foto) + "' WHERE (`id` = '" + ce.id + "');";

            MySqlCommand mySqlCommand1 = new MySqlCommand(Query, mySqlConnection1);
            mySqlCommand1.ExecuteNonQuery();
            mySqlConnection1.Close();
            MessageBox.Show("Registro Modificado exictosamente");
        }

        public DataSet Listar()
        {
            MySqlConnection mySqlConnection2 = new MySqlConnection(cadenaconexion);
            mySqlConnection2.Open();
            string Query = "select * from base_sistema_pos.clientes;";
            MySqlDataAdapter adaptador;
            DataSet DS = new DataSet();

            adaptador = new MySqlDataAdapter(Query, mySqlConnection2);
            adaptador.Fill(DS, "tbl");

            return DS;
        }

        public void Eliminar(CElogueo ce)
        {
            MySqlConnection mySqlConnection1 = new MySqlConnection(cadenaconexion);
            mySqlConnection1.Open();
            string Query = "DELETE FROM `base_sistema_pos`.`clientes` WHERE `id` = '" + ce.id + "';";


            MySqlCommand mySqlCommand1 = new MySqlCommand(Query, mySqlConnection1);
            mySqlCommand1.ExecuteNonQuery();
            mySqlConnection1.Close();
            MessageBox.Show("Registro Eliminado exictosamente");
        }
    }
}