﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace comunicasionDatos
{
    public class graficas
    {
        private decimal direccionIP { get; set; }

        private decimal ttl { get; set; }

        private decimal time { get; set; }

        private decimal bits { get; set; }


        public object this[string properTyName]
        {
            get
            {
                return this.GetType().GetProperty(properTyName).GetValue(this, null);
            }

            set
            {
                this.GetType().GetProperty(properTyName).SetValue(this, value,  null);
            }
              
        }

    }
}
