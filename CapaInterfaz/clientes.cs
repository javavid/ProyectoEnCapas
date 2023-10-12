using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;

namespace CapaInterfaz
{
    public partial class clientes : Form
    {
        public clientes()
        {
            InitializeComponent();
        }



        private void buttonnuevo_Click(object sender, EventArgs e)
        {
            limpiarForm();
        }

        private void limpiarForm()
        {
            ID.Value = 0;
            textnombre.Text = string.Empty;
            textapellido.Text = string.Empty;
            campofoto.Image = null;
        }

        private void linkFoto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog seleccionImagen = new OpenFileDialog();

            seleccionImagen.FileName = string.Empty;

            if (seleccionImagen.ShowDialog() == DialogResult.OK)
            {
                campofoto.Load(seleccionImagen.FileName);
            }
            seleccionImagen.FileName = string.Empty;
        }

        private void buttonguardar_Click(object sender, EventArgs e)
        {
            bool resultado;

            CNlogueo cNlogueo1 = new CNlogueo();
            CElogueo cElogueo1 = new CElogueo();
            cElogueo1.id = (int)ID.Value;
            cElogueo1.nombre = textnombre.Text;
            cElogueo1.apellido = textapellido.Text;
            cElogueo1.foto = campofoto.ImageLocation;

            resultado = cNlogueo1.ValidarDatos(cElogueo1);
            if (resultado == false)
            {
                return;
            }

            MessageBox.Show("todo bien vamos a insertar");

            if (cElogueo1.id == 0)
            {
                cNlogueo1.CrearClientes(cElogueo1);
            }


            limpiarForm();
        }

        
    }
}
