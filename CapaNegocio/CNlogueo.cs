using System;
using System.Windows.Forms;
using CapaEntidad;
using CapaDatos;

namespace CapaNegocio
{
    public class CNlogueo
    {
        CDlogueo capadatos = new CDlogueo();

        public void PruebaMySql() 
        {
         capadatos.PruebaConexion();
        }
    }
}