using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace validaciones
{
    public class cerrar
    {

        public static void soloNumero(KeyPressEventArgs e)
        {
      
                if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }

                else if(Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }

                else
                {
                    e.Handled = true;
                }
            
        }

       
            
        
    }
}
