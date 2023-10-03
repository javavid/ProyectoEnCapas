using System;
using MySql.Data.MySqlClient;
using CapaEntidad;
using System.Windows.Forms;

namespace CapaDatos
{
    public class CDlogueo
    {
        string cadenaconexion = "Server=localhost;User=root;Password=EderJavavid54321;port=3306;database=usuario_estudiante";


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
    }
}