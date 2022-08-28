using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace libreria_1._1
{
    public class cerrar
    {

        public static void soloNumero(KeyPressEventArgs pE)
        {
            try
            {
                if (Char.IsDigit(pE.KeyChar))
                {
                    pE.Handled = false;
                }

                else if(Char.IsControl(pE.KeyChar))
                {
                    pE.Handled = false;
                }

                else
                {
                    pE.Handled = true;
                }
            }

            catch
            {
                MessageBox.Show("hola");
            }
        }
    }
}
