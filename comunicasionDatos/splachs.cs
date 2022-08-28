using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comunicasionDatos
{
    public partial class splachs : Form
    {
        public splachs()
        {
            InitializeComponent();
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
            BarraPogreso.Value += 1; 
            if(BarraPogreso.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
            }          
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if(this.Opacity == 0)
            {
                ping llamar = new ping();
                timer2.Stop();
                llamar.Show();
                this.Hide();
            }
        }

        private void splachs_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
