using System;
using System.Windows.Forms;
using CapaEntidad;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class CNlogueo
    {
        CDlogueo capadatos = new CDlogueo();

        public void PruebaMySql()
        {
            capadatos.PruebaConexion();
        }

        public bool ValidarDatos(CElogueo cliente)
        {
            bool resultado = true;

            if (cliente.nombre == string.Empty)
            {
                resultado = false;
                MessageBox.Show("El nombre es obligatorio");
            }

            if (cliente.apellido == string.Empty)
            {
                resultado = false;
                MessageBox.Show("El apellido es obligatorio");
            }

            if (cliente.foto == null)
            {
                resultado = false;
                MessageBox.Show("La foto es obligatorio");
            }

            return resultado;
        }
        public void CrearClientes(CElogueo cE)
        {
            capadatos.Crear(cE);
        }

        public DataSet ObtenerDatos()
        {
            return capadatos.Listar();
        }

        public void EditarCliente(CElogueo cE)
        {
            capadatos.Editar(cE);
        }

        public void EliminarCliente(CElogueo cE)
        {
            capadatos.Eliminar(cE);
        }

        public void ExportarExcel2()
        {
            capadatos.ExportarExcel();
        }



            }
}