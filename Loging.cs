using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_FinalBC
{
    public partial class Loging : Form
    {
        SqlConnection Conexion = new SqlConnection("server=DESKTOP-F9337FN ; database = Logging ; INTEGRATED SECURITY = True");

        public Loging()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtNSalir_Click(object sender, EventArgs e)
        {
            {
                Application.Exit();
            }
        }

        private void Loging_Load(object sender, EventArgs e)
        {
            {
                BtNEntrar.Enabled = false;

            }


        }

        private void BtNEntrar_Click(object sender, EventArgs e)
        {
            Conexion.Open();
            SqlCommand comando = new SqlCommand("Select Usuario,Cotraseña From I_Seccion Where Usuario= @Vusuario and Cotraseña=@vclave", Conexion);
            comando.Parameters.AddWithValue("@vusuario", TxTUsuario.Text);
            comando.Parameters.AddWithValue("@vclave", TxTClave.Text);
            SqlDataReader Lector = comando.ExecuteReader();

            if (Lector.Read())
            {
                Conexion.Close();
                MenuPrincipal pantalla =new MenuPrincipal();
                pantalla.Show();
                this.Hide();
            }
            else MessageBox.Show("Datos incorrectos");

            int contador = Convert.ToInt32(LBLContador.Text);
            if (contador >= 0)
            {
                contador = contador + 1;
                LBLContador.Text = contador.ToString();
                if (contador == 3)
                {
                    MessageBox.Show("Cantidad de intento agotado");
                    LBLContador.Text = "0";
                }
            }


        }

        private void BtNRegistro_Click(object sender, EventArgs e)
        {
            RegistroUser InicioSeccion = new RegistroUser();
            InicioSeccion.Show();
            this.Hide();
        }

        private void Loging_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.F4)
            {
                e.Handled = true;
            }

            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, true, true, true, false);
            }


        }

        private void TxTUsuario_Validated(object sender, EventArgs e)
        {
            {
                BtNEntrar.Enabled = true;
            }
        }

        private void TxTClave_Validated(object sender, EventArgs e)
        {
            {
                BtNEntrar.Enabled = true;
            }
        }

        private void Loging_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, true, true, true, false);
            }
            KeyPreview = true;
        }

        private void Loging_MouseMove(object sender, MouseEventArgs e)
        {
            CloseTime.Interval = 100;

            int tp;

            tp = Convert.ToInt32(Inactividad.Text);
            tp += 1;
            Inactividad.Text = tp.ToString();

            if (tp == 500)
            {
                MessageBox.Show("Tiempo de Espera Agotado");
                Application.Exit();

            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
