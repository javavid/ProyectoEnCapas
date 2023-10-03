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
        CNlogueo capanegocio = new CNlogueo();
        public Form1()
        {
            InitializeComponent();
        }

        private void botonentrar_Click(object sender, EventArgs e)
        {
            capanegocio.PruebaMySql();
        }
    }
}