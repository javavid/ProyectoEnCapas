using System;
using CapaEntidad;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaDatos;

namespace CapaInterfaz
{
    public partial class Form1 : Form
    {
        string usuario = "eder";
        string contrase�a = "54321";

        CNlogueo capanegocio = new CNlogueo();
        public Form1()
        {
            InitializeComponent();
        }


        private void botonConexionDB_Click(object sender, EventArgs e)
        {
            capanegocio.PruebaMySql();
        }


        private void buttonsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void botonentrar_Click(object sender, EventArgs e)
        {
            if (textUsuario.Text != usuario || textContrase�a.Text != contrase�a)
            {
                if (textUsuario.Text != usuario)
                {
                    MessageBox.Show(" Usuario incorrecto ");
                    textUsuario.Clear();
                    textUsuario.Focus();
                    return;
                }
                if (textContrase�a.Text != contrase�a)
                {
                    MessageBox.Show(" Contrase�a incorrecto ");
                    textContrase�a.Clear();
                    textContrase�a.Focus();
                    return;
                }


            }
            else
            {
                textUsuario.Clear();
                textContrase�a.Clear();
                //clientes registros = new clientes();
                Menu registros = new Menu();
                registros.ShowDialog();

            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}