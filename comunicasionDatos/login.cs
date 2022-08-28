using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace comunicasionDatos
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wnsg, int wparam, int lparam);

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void texUsuario_Enter(object sender, EventArgs e)
        {
            if(texUsuario.Text == "USUARIO")
            {
                texUsuario.Text = "";
                texUsuario.ForeColor = Color.LightGray;
                
            }
        }

        private void texUsuario_Leave(object sender, EventArgs e)
        {
            if(texUsuario.Text == "")
            {
                texUsuario.Text = "USUARIO";
                texUsuario.ForeColor = Color.DimGray;
                
            }
        }

        private void textPasw_Enter(object sender, EventArgs e)
        {
        }

        private void textPasw_Leave(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(textpasword.Text == "PASWORD")
            {
                textpasword.Text = "";
                textpasword.ForeColor = Color.DarkGray;
                textpasword.UseSystemPasswordChar = true;

            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if(textpasword.Text == "")
            {
                textpasword.Text = "PASWORD";
                textpasword.ForeColor = Color.DarkGray;
                textpasword.UseSystemPasswordChar = false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle , 0x112, 0xf012, 0);
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void btnAcces_Click(object sender, EventArgs e)
        {
            if(texUsuario.Text == "jordhan" && textpasword.Text == "123456789")
            {
                splachs llamar = new splachs();
                
                
                llamar.Show();

                this.Hide();

            }

            else
            {
                MessageBox.Show("contraseña incoreccta");
            }
        }
    }
}
