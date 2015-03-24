using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebApplication4
{
    class Asunto
    {
        public int id, tyyppi, ala, huoneita;
        public bool omistus;
        public string osoite;
        public Asunto(int id, string osoite, int ala, int huoneita, int tyyppi, bool omistus)
        {
            this.id = id; this.osoite = osoite; this.ala = ala; this.huoneita = huoneita; this.tyyppi = tyyppi; this.omistus = omistus;
        } 
    }
}
