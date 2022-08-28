using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diseños
{
    class DatosIp
    {
        public string Address { get; set; }

        public decimal Ttl { get; set; }
        public int RoundtripTime { get; set; }
        public int TimeLive { get; set; }
        public int DontFranment { get; set; }



        public object this[string propertyname]
        {
            get
            {
                return this.GetType().GetProperty(propertyname).GetValue(this, null);
            }
            set
            {
                this.GetType().GetProperty(propertyname).SetValue(this, value, null);
            }
        }
    }
}
