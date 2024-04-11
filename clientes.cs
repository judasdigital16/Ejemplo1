using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cajero
{
    public partial class clientes : Form
    {
        public clientes()
        {
            InitializeComponent();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.Nombres = txtnombres.Text;
                Properties.Settings.Default.Apellidos = txtApellidos.Text;
                Properties.Settings.Default.Cedula = txtcedula.Text;
                Properties.Settings.Default.Contraseña = txtcontraseña.Text;
                Properties.Settings.Default.Saldo = txtsaldo.Text;
                Properties.Settings.Default.Puntos = txtpuntos.Text;
                Properties.Settings.Default.Save();
                MessageBox.Show("Cliente registrado");
            }

            // Inicio exsepcion
            catch (Exception)
            {
                throw;
            }
        }
        private void clientes_Load(object sender, EventArgs e)
        {
            txtnombres.Text = Properties.Settings.Default.Nombres;
            txtApellidos.Text = Properties.Settings.Default.Apellidos;
            txtcedula.Text = Properties.Settings.Default.Cedula;
            txtcontraseña.Text = Properties.Settings.Default.Contraseña;
            txtsaldo.Text = Properties.Settings.Default.Saldo;
            txtpuntos.Text = Properties.Settings.Default.Puntos;

        }

        private void btregresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
