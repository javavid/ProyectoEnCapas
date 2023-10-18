using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaInterfaz
{
    public partial class Menu : Form
    {
        CNlogueo cNlogueo2 = new CNlogueo();
        public Menu()
        {
            InitializeComponent();
        }

        private void linkFoto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            {
                OpenFileDialog seleccionImagen = new OpenFileDialog();

                seleccionImagen.FileName = string.Empty;

                if (seleccionImagen.ShowDialog() == DialogResult.OK)
                {
                    campofoto.Load(seleccionImagen.FileName);
                }
                seleccionImagen.FileName = string.Empty;
            }
        }

        private void botonNuevo_Click(object sender, EventArgs e)
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

        private void botonGuardar_Click(object sender, EventArgs e)
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
            else
            {
                cNlogueo1.EditarCliente(cElogueo1);
            }

            limpiarForm();
            cargarDatos();
        }



        private void clientes_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void cargarDatos()
        {
            dataGrid.DataSource = cNlogueo2.ObtenerDatos().Tables["tbl"];
        }

        private void dataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ID.Value = (int)dataGrid.CurrentRow.Cells["id"].Value;
            textnombre.Text = dataGrid.CurrentRow.Cells["nombre"].Value.ToString();
            textapellido.Text = dataGrid.CurrentRow.Cells["apellido"].Value.ToString();
            campofoto.Load(dataGrid.CurrentRow.Cells["foto"].Value.ToString());
        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            if (ID.Value == 0)
            {
                return;
            }

            if (MessageBox.Show("Estas seguro?", "eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;

            CElogueo cElogueo2 = new CElogueo();
            cElogueo2.id = (int)ID.Value;
            cNlogueo2.EliminarCliente(cElogueo2);
            cargarDatos();
            limpiarForm();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void clientes_Click(object sender, EventArgs e)
        {

        }
    }
}
