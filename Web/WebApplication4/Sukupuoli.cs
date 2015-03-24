using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebApplication4
{
    class Sukupuoli
    {
        public Sukupuoli(int id, string selite)
        {
            this.selite = selite;
            this.id = id;
        }
        public string selite { get; set; }
        public int id { get; set; }
    }
}
