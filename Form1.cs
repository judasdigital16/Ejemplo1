namespace Cajero
{
    public partial class Cajero : Form
    {

        int limit = 50000;


        public Cajero()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            string lastChar = txtcontraseña.Text.Substring(0, txtcontraseña.TextLength -1);
            txtcontraseña.Text = lastChar;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            string contraseña = Properties.Settings.Default.Contraseña;

            if(txtcontraseña.Text == contraseña)
            {
                tabControl1.SelectTab(1);

            }
            else
            {
                MessageBox.Show("Contraseña incorrescta, ", "Validar");
                txtcontraseña.Text = "";
            }

        }

        private void btsaldo_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
            lblsaldo.Text = Properties.Settings.Default.Saldo;
        }

        private void btcancelar_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
            txtcontraseña.Text = "";
        }

        private void btretiro_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(3);
            new_saldo.Text = Properties.Settings.Default.Saldo;

        }

        private void btn50_Click(object sender, EventArgs e)
        {
            WithDraw(50000);
        }


            //inicio metodo
            private void WithDraw(Double restar_saldo)
            {

              double saldo = double.Parse(new_saldo.Text);

            //validacion de fondos
               if(saldo >= restar_saldo && restar_saldo < limit)
            {
                double ca = saldo - restar_saldo;
                Properties.Settings.Default.Saldo = Convert.ToString(ca);
                Properties.Settings.Default.Save();
                MessageBox.Show("¡Por favor retire su dinero!");

            }
            else
            {
                MessageBox.Show("SALDO INSUFICIENTE, Intente nuevamente");
            }
            }

        private void bt100_Click(object sender, EventArgs e)
        {
            WithDraw(100000);
        }

        private void bt200_Click(object sender, EventArgs e)
        {
            WithDraw(200000);
        }

        private void bt20_Click(object sender, EventArgs e)
        {
            WithDraw(20000);
        }

        private void bt40_Click(object sender, EventArgs e)
        {
            WithDraw(40000);
        }

        private void btcantidad_Click(object sender, EventArgs e)
        {
            string request = Microsoft.VisualBasic.Interaction.InputBox("INGRESE CANTIDAD","Cantidad:","0");
            double plata =  double.Parse(request);
            MessageBox.Show (""+ plata);
            WithDraw(plata);
        }

        private void bttransferencia_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(5);
        }

        private void btregistro_Click(object sender, EventArgs e)
        {
            Form registrar = new clientes();
            registrar.Show();
        }

        private void btregresar_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void btconsulta_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(4);
            lblpuntos.Text = Properties.Settings.Default.Puntos;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string cedula = Properties.Settings.Default.Cedula;

            if (txtcedula.Text == cedula)
            {
                tabControl1.SelectTab(6);
               

            }
            else
            {
                MessageBox.Show("El usuario no existe en nuestra base de datos, ", "Validar");
                txtcontraseña.Text = "";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new_saldo.Text = Properties.Settings.Default.Saldo;

            string request = Microsoft.VisualBasic.Interaction.InputBox("INGRESE CANTIDAD A ENVIAR", "Cantidad:", "0");
            double tran = double.Parse(request);
            MessageBox.Show("Monto a girar" + tran);
            Giro(tran);

        }

        //inicio metodo giro
        private void Giro (Double restar_giro)
        {

            double saldo = double.Parse(new_saldo.Text);

            //validacion de fondos
            if (saldo >= restar_giro)
            {
                double gi = saldo - restar_giro;
                Properties.Settings.Default.Saldo = Convert.ToString(gi);
                Properties.Settings.Default.Save();
                MessageBox.Show("¡Giro exitoso!");

            }
            else
            {
                MessageBox.Show("SALDO INSUFICIENTE, Intente nuevamente");
            }
        }




        private void button7_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

       


    }
}