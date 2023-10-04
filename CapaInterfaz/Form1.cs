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
        string usuario = "David";
        string contraseña = "54321";

        CNlogueo capanegocio = new CNlogueo();
        public Form1()
        {
            InitializeComponent();
        }


        private void buttonsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void botonentrar_Click(object sender, EventArgs e)
        {
            if (textUsuario.Text != usuario || textContraseña.Text != contraseña)
            {
                if (textUsuario.Text != usuario)
                {
                    MessageBox.Show(" Usuario incorrecto ");
                    textUsuario.Clear();
                    textUsuario.Focus();
                    return;
                }
                if (textContraseña.Text != contraseña)
                {
                    MessageBox.Show(" Contraseña incorrecto ");
                    textContraseña.Clear();
                    textContraseña.Focus();
                    return;
                }
                //capanegocio.PruebaMySql();

            }
            else
            {
                textUsuario.Clear();
                textContraseña.Clear();
                Form2 registros = new Form2();
                registros.ShowDialog();
                
            }

            
        }
    }
}