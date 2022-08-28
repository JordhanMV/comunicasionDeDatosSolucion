using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diseños
{
    public class datosGrid
    {

        public decimal direccionIP { get; set; }

        public decimal Time1 { get; set; }

        public decimal Time2 { get; set; }

        public decimal time3 { get; set; }

        public decimal Time4 { get; set; }

        public decimal Time5 { get; set; }

        public decimal Time6 { get; set; }




        public object this[string properTyName]
        {
            get
            {
                return this.GetType().GetProperty(properTyName).GetValue(this, null);
            }

            set
            {
                this.GetType().GetProperty(properTyName).SetValue(this, value, null);
            }

        }
    }
}
