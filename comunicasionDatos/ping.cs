using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//estas las librerias
using System.Threading.Tasks;
using System.Net;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using diseños;
using SolucionPing;





namespace comunicasionDatos
{

   

    public partial class ping : Form
    {

        

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wnsg, int wparam, int lparam);

        

        public ping()
        {
            InitializeComponent();
        }

     

        

        private void ping_Load(object sender, EventArgs e)
        {
            
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            //inicialisacion del boton
            //las repeticiones del boton
            try
            {

                for (int i = 0; i < 5; i++)
            {
                System.Net.NetworkInformation.Ping myRequest = new System.Net.NetworkInformation.Ping();
                myRequest.SendAsync(textPing.Text, null);
                //myRequest.SendAsync(textPing2.Text, null);
                myRequest.PingCompleted += pingCompleto;
            }
            }

            catch
            {
                MessageBox.Show("no pusiste nada");
                
            }

        }
           



        private void pingCompleto(object source, System.Net.NetworkInformation.PingCompletedEventArgs e)
        {

            //condisional del ping
            try
            {
                if (!e.Cancelled)
                {

                    dgDatos.Rows.Add(Environment.NewLine + e.Reply.Address.ToString(), Environment.NewLine + e.Reply.Options.Ttl, Environment.NewLine + e.Reply.RoundtripTime.ToString(), Environment.NewLine + e.Reply.Options.DontFragment.ToString(), Environment.NewLine + e.Reply.Buffer.Length.ToString());
                }

                else
                {
                    RichPing.Text += Environment.NewLine + "somenting went wrong";
                }
            }
            catch
            {
                MessageBox.Show("algo esta mal");
            }



        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void txtEnter(object sender, EventArgs e)
        {
            //efectos de usuario
            TextBox txt = sender as TextBox;
            foreach (Control ctrl in pConteier.Controls)
            {
                if(ctrl is PictureBox && ctrl.Name == "pb" + txt.Tag.ToString())
                {
                    ctrl.BackColor = Color.FromArgb(79, 129, 189);
                    
                }

                if(ctrl is Label && ctrl.Name == "lbl" + txt.Tag.ToString())
                {
                    ctrl.ForeColor = Color.FromArgb(79, 129, 189);
                }
                
            }
        }

        private void txtLeave(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            foreach (Control ctrl in pConteier.Controls)
            {
                if (ctrl is PictureBox && ctrl.Name == "pb" + txt.Tag.ToString())
                {
                    ctrl.ForeColor = Color.Black;

                    if (txt.Text == string.Empty)
                    {
                        ctrl.BackColor = Color.Red;
                    }
                    else
                    {
                        ctrl.BackColor = Color.Black;

                        if (txt.Text == string.Empty)
                        {
                            
                            ctrl.BackColor = Color.Red;

                        }
                        else
                        {
                            ctrl.BackColor = Color.Black;
                        }
                    }
                }

                if(ctrl is Label && ctrl.Name == "lbl" + txt.Tag.ToString())
                {
                    ctrl.ForeColor = Color.Black;

                    if (txt.Text == string.Empty)
                    {
                        ctrl.ForeColor = Color.Red;
                    }
                    else
                    {
                        ctrl.ForeColor = Color.Black;

                        if (txt.Text == string.Empty)
                        {
                            ctrl.ForeColor = Color.Red;
                        }
                        else
                        {
                            ctrl.ForeColor = Color.Black;
                        }
                    }
                }
                
            }
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {  //para mover el formulario                 
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);        
        }

        private void textPing_TextChanged(object sender, EventArgs e)
        {
            


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //para leer el dock
            string ubicasion = @"C:\Users\user\Desktop\archivo.txt";
            string leer = File.ReadAllText(ubicasion);
            RichPing.Text = leer;
        }

        private void btnGuaradarr_Click(object sender, EventArgs e)
        {
            //para guardar
            StreamWriter escribir = new StreamWriter(@"C:\Users\user\Desktop\archivo.txt", true);

            try
            {
                
                escribir.WriteLine("resultados del ping " + "\n");
                escribir.WriteLine("address: " + dgDatos.CurrentRow.Cells[0].Value.ToString());
                escribir.WriteLine("\n" + "ttl: " + dgDatos.CurrentRow.Cells[1].Value.ToString());
                escribir.WriteLine("\n" + "time: " + dgDatos.CurrentRow.Cells[2].Value.ToString());
                escribir.WriteLine("\n" + "pack: " + dgDatos.CurrentRow.Cells[3].Value.ToString());
                escribir.WriteLine("\n" + "bit: " + dgDatos.CurrentRow.Cells[4].Value.ToString());
            }

            catch
            {
                MessageBox.Show("error");
            }
            escribir.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                this.RichPing.Clear();
            }

            else if(radioButton2.Checked)
            {
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void textPing2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textPing_KeyPress(object sender, KeyPressEventArgs e)
        {

            validaciones.letrasDecimales(e);
            
        }

        private void btnDns_Click(object sender, EventArgs e)
        {
            try
            {

                for (int i = 0; i < 5; i++)
                {
                    System.Net.NetworkInformation.Ping myRequest = new System.Net.NetworkInformation.Ping();
                    myRequest.SendAsync(textDns.Text, null);
                    //myRequest.SendAsync(textPing2.Text, null);
                    myRequest.PingCompleted += Dnscompleto;
                }
            }

            catch
            {
                MessageBox.Show("error  malo");

            }
        }

        private void Dnscompleto(object source, System.Net.NetworkInformation.PingCompletedEventArgs e)
        {

            //condisional del ping
            try
            {
                if (!e.Cancelled)
                {

                    dgDns.Rows.Add(Environment.NewLine + e.Reply.Address.ToString(), Environment.NewLine + e.Reply.Options.Ttl, Environment.NewLine + e.Reply.RoundtripTime.ToString(), Environment.NewLine + e.Reply.Options.DontFragment.ToString(), Environment.NewLine + e.Reply.Buffer.Length.ToString());
                }

                else
                {
                    RichPing.Text += Environment.NewLine + "somenting went wrong";
                }
            }
            catch
            {
                MessageBox.Show("algo esta mal");
            }



        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            validaciones.NumerosDecimales(e);
        }

        private void btnGuaradarDns_Click(object sender, EventArgs e)
        {
            StreamWriter escribir = new StreamWriter(@"C:\Users\lab1-pc02\Desktop\arhivo.txt", true);

            try
            {

                escribir.WriteLine("resultados del ping " + "\n");
                escribir.WriteLine("address: " + dgDns.CurrentRow.Cells[0].Value.ToString());
                escribir.WriteLine("\n" + "ttl: " + dgDns.CurrentRow.Cells[1].Value.ToString());
                escribir.WriteLine("\n" + "time: " + dgDns.CurrentRow.Cells[2].Value.ToString());
                escribir.WriteLine("\n" + "pack: " + dgDns.CurrentRow.Cells[3].Value.ToString());
                escribir.WriteLine("\n" + "bit: " + dgDns.CurrentRow.Cells[4].Value.ToString());
            }

            catch
            {
                MessageBox.Show("se guardo");
            }
            escribir.Close();
        }

        private void btnLeerDns_Click(object sender, EventArgs e)
        {
            //para leer el dock
            string ubicasion = @"C:\Users\lab1-pc02\Desktop\arhivo.txt";
            string leer = File.ReadAllText(ubicasion);
            RichPing.Text = leer;
        }

        private void btnGraficas_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RichPing_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGraficas_Click_1(object sender, EventArgs e)
        {
            frmPingIP llamar = new frmPingIP();
            llamar.Show();

            

            
        }

        private void btbLlevar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
