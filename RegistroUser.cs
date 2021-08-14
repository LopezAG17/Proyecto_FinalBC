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
    public partial class RegistroUser : Form
    {

        SqlConnection Conexion = new SqlConnection("server=DESKTOP-F9337FN ; database = Logging ; INTEGRATED SECURITY = True");
        public RegistroUser()
        {
            InitializeComponent();
        }

       

        private void BtNSalir_Click(object sender, EventArgs e)
        {
            MenuPrincipal Obj = new MenuPrincipal();

            if (Obj.Visible == false)
            {
                Obj.Show();
                Close();
            }
            else
            {
                     Loging Atras = new Loging();
                     Atras.Show();
                     Close();
            }
           

           
        }

        private void BtNRegistro_Click(object sender, EventArgs e)
        {
            String Query = "Insert into I_Seccion(Usuario,Cotraseña,Correo) values (@usuario,@clave,@correo)";
           
            Conexion.Open();
          
            SqlCommand Cmd2 = new SqlCommand(Query, Conexion);
            SqlCommand Cmd = new SqlCommand("Insert into Informacion(NombreU,ApellidoU,Cedula,Telefono,Sexo,Fecha,CorreoU) values (@nombre,@apellido,@cedula,@telefono,@sexo,(CONVERT(Varchar(40),GETDATE(),3)),@correoU)", Conexion);
            Cmd2.Parameters.AddWithValue("@usuario", TxTRUsuario.Text);
            Cmd2.Parameters.AddWithValue("@correo", TxTRCorreo.Text);
            Cmd2.Parameters.AddWithValue("@clave", TxTRClave.Text);
            Cmd.Parameters.AddWithValue("@nombre", TxTRNombre.Text);
            Cmd.Parameters.AddWithValue("@apellido", TxTRApellido.Text);
            Cmd.Parameters.AddWithValue("@cedula", TxTCedula.Text); 
            Cmd.Parameters.AddWithValue("@telefono",TxTRTelefono.Text);        
            Cmd.Parameters.AddWithValue("@sexo", CBSexo.Text);          
            Cmd.Parameters.AddWithValue("@correoU", TxTRCorreo.Text);





            Cmd.ExecuteNonQuery();
            Cmd2.ExecuteNonQuery();

            MessageBox.Show("Registro completado con exito");
            Conexion.Close();
        }

       

        private void TxTCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar)) //Al pulsar una letra.            
            {
                e.Handled = true; //Se acepta (todo OK).            
            }
            KeyPreview = true;
        }

        private void TxTRUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) //Al pulsar una letra.            
            {
                e.Handled = true;   //Se acepta (todo OK).            
            }

        }

        private void RegistroUser_Load(object sender, EventArgs e)
        {
            {
                BtNRegistro.Enabled = false;
                
            }

        }

        
        private void RegistroUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, true, true, true, false);
            }
            if (e.KeyCode == Keys.F10)
            {
                if (MessageBox.Show("Esta Seguro que Desea Salir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    Application.Exit();
                }
                KeyPreview = true;
            }

            if (e.Alt && e.KeyCode == Keys.F4)
            {
                e.Handled = true;
                if (MessageBox.Show("Esta Seguro que Desea Salir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    Application.Exit();
                }
                KeyPreview = true;
            }

            KeyPreview = true;


        }

        private void TxTRUsuario_Validated(object sender, EventArgs e)
        {
            if (TxTRUsuario.Text == string.Empty)
            {
                MessageBox.Show("Debe Completar el Campo");
                    TxTRUsuario.Focus();
                
            }
            {
                BtNRegistro.Enabled = true;
            }
        }

        private void TxTRNombre_Validated(object sender, EventArgs e)
        {
            if (TxTRNombre.Text == string.Empty)
            {
                MessageBox.Show("Debe Completar el Campo");
                TxTRNombre.Focus();
            }
        }

        private void TxTRApellido_Validated(object sender, EventArgs e)
        {
            if (TxTRApellido.Text == string.Empty)
            {
                MessageBox.Show("Debe Completar el Campo");
                TxTRApellido.Focus();
            }
        }

        private void TxTRCorreo_Validated(object sender, EventArgs e)
        {
            if (TxTRCorreo.Text == string.Empty)
            {
                MessageBox.Show("Debe Completar el Campo");
                TxTRCorreo.Focus();
            }
        }

        private void TxTRClave_Validated(object sender, EventArgs e)
        {
            if (TxTRClave.Text == string.Empty)
            {
                MessageBox.Show("Debe Completar el Campo");
                TxTRClave.Focus();
            }
        }

        private void TxTCedula_Validated(object sender, EventArgs e)
        {
            if (TxTCedula.Text == string.Empty)
            {
                MessageBox.Show("Debe Completar el Campo");
                TxTCedula.Focus();
            }
        }

        private void TxTRTelefono_Validated(object sender, EventArgs e)
        {
            if (TxTRTelefono.Text == string.Empty)
            {
                MessageBox.Show("Debe Completar el Campo");
                TxTRTelefono.Focus();
            }
        }

        private void CBSexo_Validated(object sender, EventArgs e)
        {
            if (CBSexo.Text == string.Empty)
            {
                MessageBox.Show("Debe Completar el Campo");
                CBSexo.Focus();
            }
        }

        private void CBSexo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TxTRNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) //Al pulsar una letra.            
            {
                e.Handled = true;   //Se acepta (todo OK).            
            }
            KeyPreview = true;
        }

        private void TxTRApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (Char.IsDigit(e.KeyChar)) //Al pulsar una letra.            
                {
                    e.Handled = true;   //Se acepta (todo OK).            
                }
                KeyPreview = true;
            }

        }
    }
}
