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
    public partial class MenuPrincipal : Form
    {

        SqlConnection Conexion = new SqlConnection("server=DESKTOP-F9337FN ; database = Logging ; INTEGRATED SECURITY = True");

        public MenuPrincipal()
        {
            InitializeComponent();
        }

       

        private void BtNregistroM_Click(object sender, EventArgs e)
        {
            RegistroUser NuevoRegistro = new RegistroUser();
            NuevoRegistro.Show();
            Close();
        }

        private void Close_Tick(object sender, EventArgs e)
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

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            {
                BtNBorrar.Enabled = false;
            }
        }

        private void MenuPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.F4)
            {
                e.Handled = true;
            }
            KeyPreview = true; 
        }

        private void MenuPrincipal_MouseMove(object sender, MouseEventArgs e)
        {
            {
                Inactividad.Text = "0";
            }

        }

        private void BtNSalirM_Click(object sender, EventArgs e)
        {
            {
                Application.Exit();
            }
        }

        private void BtNBorrar_Validated(object sender, EventArgs e)
        {
            Loging User = new Loging();
            
          
            SqlCommand comando = new SqlCommand("Select Usuario,Contraseña From I_Seccion Where Rango=Administrador", Conexion);

            
            SqlDataReader Lector = comando.ExecuteReader();

            if (Lector.Read())
            {
                Conexion.Close();
                BtNBorrar.Enabled = true;
            }
        }

        private void BtNBuscar_Click(object sender, EventArgs e)
        {
            Conexion.Open();
            SqlCommand CMDUsuario = new SqlCommand("Select NombreU as Nombre,ApellidoU as Apellido,Cedula, Sexo From Informacion Where NombreU=@nombre ",Conexion);
            SqlCommand CMDCorreo = new SqlCommand("Select CorreoU as Correo ,NombreU as Nombre,ApellidoU as Apellido,Cedula,  Apellido From Informacion Where Correo=Correo ",Conexion);
            SqlCommand CMDCedula = new SqlCommand("Select CorreoU as Correo ,NombreU as Nombre,ApellidoU as Apellido,Cedula,  Apellido From Informacion Where Cedula=@Cedula ",Conexion);
            CMDUsuario.Parameters.AddWithValue("@nombre", TxTReferencia.Text);
            CMDCorreo.Parameters.AddWithValue("@Cedula", TxTReferencia.Text);
            CMDCedula.Parameters.AddWithValue("@Correo", TxTReferencia.Text);
            SqlDataAdapter adapterCo = new SqlDataAdapter();
            SqlDataAdapter adapterUs = new SqlDataAdapter();
            SqlDataAdapter adapterCe = new SqlDataAdapter();
            adapterUs.SelectCommand = CMDUsuario;
            adapterCe.SelectCommand = CMDCedula;
            adapterCo.SelectCommand = CMDCorreo;
            DataTable tabla = new DataTable();
            

            if (CBBusqueda.Text=="Nombre")
            {
                adapterUs.Fill(tabla);
                Busqueda.DataSource = tabla;
                Conexion.Close();
            }
            if (CBBusqueda.Text == "Correo")
            {
                adapterCo.Fill(tabla);
                Busqueda.DataSource = tabla;
                Conexion.Close();
            }
            if (CBBusqueda.Text == "Cedula")
            {
                adapterCe.Fill(tabla);
                Busqueda.DataSource = tabla;
                Conexion.Close();
            }


        }

        private void CBBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) //Al pulsar una letra.            
            {
                e.Handled = true;   //Se acepta (todo OK).            
            }
            if (Char.IsLetter(e.KeyChar)) //Al pulsar una letra.            
            {
                e.Handled = true; //Se acepta (todo OK).            
            }
            if (Char.IsLetter(e.KeyChar)) //Al pulsar una tecla.            
            {
                e.Handled = true; //Solo acepta numeros(todo OK).
                MessageBox.Show("No puedes editar este campo");
            }
            if (Char.IsDigit(e.KeyChar)) //Al pulsar una tecla.            
            {
                e.Handled = true;  //Acepta letras OK.   
                MessageBox.Show("No puedes editar este campo");
            }



        }
    }
}
